using System;
using kintoneDotNetSDK.authentication;
using kintoneDotNetSDK.model.http;
using System.Collections.Generic;
using kintoneDotNetSDK.exception;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.connection
{
    public class Connection
    {
        /// HTTP header content-type for getting json data from rest api.
        private string JSON_CONTENT = "application/json";

        /// HTTP header content-type for multipart/form-data
        private string MULTIPART_CONTENT = "multipart/form-data; boundary=";

        /// User agent http header.
        private string userAgent = ConnectionConstants.USER_AGENT_VALUE;

        /// Object contains user's credential.
        private Auth auth;

        /// Kintone domain url.
        private string domain;

        /// Guest space number in kintone domain.
        /// User describe it when connect data in guest space.
        private int? guestSpaceID = -1;

        /// Contains addition headers user set.
        private List<HTTPHeader> headers = new List<HTTPHeader>();

        /// Contains information for bypass proxy.
        private string proxyHost = "";
        private int? proxyPort;


        public Connection(string domain, Auth auth, int guestSpaceID = -1)
        {
            this.domain = domain;
            this.auth = auth;
            this.guestSpaceID = guestSpaceID;
            //if let version = Bundle(for: type(of: self)).object(forInfoDictionaryKey: "CFBundleShortVersionString") as? String {
            //    self.userAgent += "/" + version
            //}
        }

        private string GetURL(string apiName, string parameters)
        {
            if (String.IsNullOrEmpty(this.domain))
            {
                throw new KintoneAPIException("domain is empty");
            }
            string unwrappedDomain = this.domain;

            if (String.IsNullOrEmpty(apiName))
            {
                throw new KintoneAPIException("api is empty");
            }
            string unwrappedApiName = apiName;

            StringBuilder sb = new StringBuilder();
            if (!this.domain.Contains(ConnectionConstants.HTTPS_PREFIX))
            {
                sb.Append(ConnectionConstants.HTTPS_PREFIX);
            }
            sb.Append(unwrappedDomain);

            var urlString = ConnectionConstants.BASE_URL;
            if (this.guestSpaceID != null)
            {
                if (this.guestSpaceID.Value >= 0)
                {
                    urlString = ConnectionConstants.BASE_GUEST_URL.Replace("{GUEST_SPACE_ID}", this.guestSpaceID.Value.ToString());
                }
            }
            urlString = urlString.Replace("{API_NAME}", unwrappedApiName);

            sb.Append(urlString);
            if (!String.IsNullOrEmpty(parameters))
            {
                sb.Append(parameters);
            }

            sb = sb.Replace("¥¥s", "%20");
            return sb.ToString();
        }

        private HttpRequestMessage SetHTTPHeaders(HttpRequestMessage request)
        {
            foreach (HTTPHeader header in this.auth.CreateHeaderCredentials())
            {
                if (header != null && !String.IsNullOrEmpty(header.GetKey()) && !String.IsNullOrEmpty(header.GetValue()))
                {
                    string unwrap_getvalue = header.GetValue();
                    string unwrap_getKey = header.GetKey();
                    request.Headers.Add(unwrap_getKey, unwrap_getvalue);
                }
            }
            request.Headers.Add(ConnectionConstants.USER_AGENT_KEY, this.userAgent);
            foreach (HTTPHeader header in this.headers)
            {
                if (!String.IsNullOrEmpty(header.GetKey()) && !String.IsNullOrEmpty(header.GetValue()))
                {
                    string unwrap_getvalue = header.GetValue();
                    string unwrap_getKey = header.GetKey();
                    request.Headers.Add(unwrap_getKey, unwrap_getvalue);
                }
            }

            return request;
        }

        public async Task<String> Request(string method, string apiName, string body)
        {
            string urlString = "";
            bool isGet = false;
            HttpMethod httpMethod = null;

            if (ConnectionConstants.GET_REQUEST == method)
            {
                isGet = true;
                httpMethod = new HttpMethod(ConnectionConstants.POST_REQUEST);
            }
            else
            {
                httpMethod = new HttpMethod(method);
            }


            urlString = this.GetURL(apiName, "");
            Uri url = new Uri(urlString);
            HttpRequestMessage requestMessage = new HttpRequestMessage(httpMethod, url);
            requestMessage = this.SetHTTPHeaders(requestMessage);
            //requestMessage.Headers.Add(ConnectionConstants.CONTENT_TYPE_HEADER, this.JSON_CONTENT);
            if (isGet)
            {
                requestMessage.Headers.Add(ConnectionConstants.METHOD_OVERRIDE_HEADER, method);
            }
            var stringContent = new StringContent(body, Encoding.UTF8, this.JSON_CONTENT);
            requestMessage.Content = stringContent;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            HttpClient httpClient = new HttpClient(SetHttpClientConfiguration());
            try
            {
                using (var response = await httpClient.SendAsync(requestMessage))
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode == false)
                    {
                        this.checkStatus(response, content, apiName);
                    }

                    return content;
                }
            }
            catch (KintoneAPIException kintoneException)
            {
                throw kintoneException;
            }
            catch (HttpRequestException httpRequestException)
            {
                throw httpRequestException;
            }
        }

        private HttpClientHandler SetHttpClientConfiguration()
        {
            HttpClientHandler config = null;
            if (!String.IsNullOrEmpty(this.proxyHost) || this.proxyPort != null)
            {
                config = new HttpClientHandler()
                {
                    UseProxy = true,
                    Proxy = new WebProxy(this.proxyHost, this.proxyPort.Value),
                    UseDefaultCredentials = false,
                    Credentials = CredentialCache.DefaultCredentials,
                };
            }
            return config;
        }

        private async Task<HttpResponseMessage> Execute(HttpClient client, HttpRequestMessage requestMessage)
        {
            return await client.SendAsync(requestMessage);
        }

        public Connection SetHeader(string key, string value)
        {
            this.headers.Add(new HTTPHeader(key, value));
            return this;
        }

        public Connection SetAuth(Auth auth)
        {
            this.auth = auth;
            return this;
        }

        public string GetDomain()
        {
            return this.domain;
        }

        public string GetGuestSpaceId()
        {
            return this.guestSpaceID.Value.ToString();
        }

        public Auth GetAuth()
        {
            return this.auth;
        }

        public void SetProxy(string host, int port)
        {
            this.proxyHost = host;
            this.proxyPort = port;
        }

        public string GetPathURI(string apiName)
        {
            var pathURI = "";

            if (this.guestSpaceID != null)
            {
                if (this.guestSpaceID.Value >= 0)
                {
                    pathURI = ConnectionConstants.BASE_GUEST_URL;
                    pathURI = pathURI.Replace("{GUEST_SPACE_ID}", this.guestSpaceID.Value.ToString());
                }
                else
                {
                    pathURI = ConnectionConstants.BASE_URL;
                }
            }
            else
            {
                pathURI = ConnectionConstants.BASE_URL;
            }

            pathURI = pathURI.Replace("{API_NAME}", apiName);
            return pathURI;
        }

        private ErrorResponse getErrorResponse(string content)
        {
            if (!String.IsNullOrEmpty(content))
            {
                try
                {
                    var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(content);
                    return errorResponse;
                }
                catch (JsonReaderException ex)
                {
                    return null;
                }
            }
            return null;
        }
        private void checkStatus(HttpResponseMessage http_response, string content, string apiName)
        {
            var statusCode = (int)http_response.StatusCode;
            if (statusCode == 401)
            {
                throw new KintoneAPIException("401 Unauthorized");
            }

            if (statusCode != 200)
            {
                if (apiName == ConnectionConstants.BULK_REQUEST)
                {
                    //try {
                    //    if let unWrapResponses: Array<ErrorResponse> = self.getErrorResponses(data) {
                    //        if let jsonBody = body?.data(using: String.Encoding.utf8) {
                    //            let jsonobject = try JSONSerialization.jsonObject(with: jsonBody, options: JSONSerialization.ReadingOptions.allowFragments)

                    //            let jsonArray = (jsonobject as! NSDictionary)["requests"] as! NSArray
                    //            let jsonRequest = try JSONSerialization.data(withJSONObject: jsonArray, options: [])
                    //            let errorResponseList: Array<BulkRequestItem>  = try decoder.decode([BulkRequestItem].self, from: jsonRequest)
                    //            throw KintoneAPIException(statusCode, errorResponseList, unWrapResponses)
                    //        } else {
                    //            throw KintoneAPIException("http status error(\(String(describing: statusCode)))")
                    //        }
                    //    } else {
                    //        if let unWrapResponse = self.getErrorResponse(data) {
                    //            throw KintoneAPIException(statusCode, unWrapResponse)
                    //        } else {
                    //            throw KintoneAPIException("http status error(\(String(describing: statusCode)))")
                    //        }
                    //    }
                    //} 
                }
                else
                {
                    var unWrapResponse = this.getErrorResponse(content);
                    if (unWrapResponse != null)
                    {
                        throw new KintoneAPIException(statusCode, unWrapResponse);
                    }
                    else
                    {
                        throw new KintoneAPIException("http status error " + statusCode.ToString());
                    }
                }
            }
        }
    }
}
