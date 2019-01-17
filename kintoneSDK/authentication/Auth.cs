using System;
using kintoneDotNetSDK.model.authentication;
using kintoneDotNetSDK.model.http;
using System.Text;
using System.Collections.Generic;

namespace kintoneDotNetSDK.authentication
{
    public class Auth
    {
        private Credential basicAuth;
        private Credential passwordAuth;
        private string apiToken;

        public Auth()
        {
        }

        public Auth SetBasicAuth(string username, string password)
        {
            this.basicAuth = new Credential(username, password);
            return this;
        }

        public Credential GetBasicAuth()
        {
            return this.basicAuth;
        }

        public Auth SetPasswordAuth(string username, string password)
        {
            this.passwordAuth = new Credential(username, password);
            return this;
        }

        public Credential GetPasswordAuth()
        {
            return this.passwordAuth;
        }

        public Auth SetApiToken(string apiToken)
        {
            this.apiToken = apiToken;
            return this;
        }

        public string GetApiToken()
        {
            return this.apiToken;
        }

        public List<HTTPHeader> CreateHeaderCredentials()
        {
            List<HTTPHeader> headers = new List<HTTPHeader>();

            if (this.passwordAuth != null)
            {
                var passwordAuthString = this.passwordAuth.GetUserName() + ":" + this.passwordAuth.GetPassword();
                var passwordAuthData = Encoding.UTF8.GetBytes(passwordAuthString);
                var httpHeader = new HTTPHeader(AuthenticationConstants.HEADER_KEY_AUTH_PASSWORD, System.Convert.ToBase64String(passwordAuthData));
                headers.Add(httpHeader);
            }

            if (!string.IsNullOrEmpty(this.apiToken))
            {
                var httpHeader = new HTTPHeader(AuthenticationConstants.HEADER_KEY_AUTH_APITOKEN, this.apiToken);
                headers.Add(httpHeader);
            }

            if (this.basicAuth != null)
            {
                var basicAuthString = this.basicAuth.GetUserName() + ":" + this.basicAuth.GetPassword();
                var basicAuthData = Encoding.UTF8.GetBytes(basicAuthString);
                var httpHeader = new HTTPHeader(AuthenticationConstants.HEADER_KEY_AUTH_BASIC, AuthenticationConstants.AUTH_BASIC_PREFIX + System.Convert.ToBase64String(basicAuthData));
                headers.Add(httpHeader);
            }
            return headers;

        }
    }
}
