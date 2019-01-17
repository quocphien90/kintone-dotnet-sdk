using System;
using kintoneDotNetSDK.connection;
using kintoneDotNetSDK.exception;
using kintoneDotNetSDK.module.parser;
using kintoneDotNetSDK.model.app.basic.request;
using kintoneDotNetSDK.model.app.basic.response;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace kintoneDotNetSDK.module.app
{
    public class App
    {
        Connection connection = null;
        Parser parser = new Parser();
        public App(Connection connection)
        {
            this.connection = connection;
        }
        public async Task<GetAppDeployStatusResponse> GetAppDeployStatus(int[] apps)
        {
            try
            {
                var deployStatusRequest = new GetAppDeployStatusRequest(apps);
                var jsonBody = this.parser.ParseObjectToJson(deployStatusRequest);
                var responseString = await this.connection.Request(ConnectionConstants.GET_REQUEST, ConnectionConstants.APP_DEPLOY_PREVIEW, jsonBody);
                return this.parser.ParseJsonToObject<GetAppDeployStatusResponse>(responseString);
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
    }

}
