using System;
using kintoneDotNetSDK.connection;
using kintoneDotNetSDK.exception;
using kintoneDotNetSDK.module.parser;
using kintoneDotNetSDK.model.app.basic.request;
using kintoneDotNetSDK.model.app.basic.response;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using kintoneDotNetSDK.model.app.app;
using System.Collections.Generic;
using kintoneDotNetSDK.model.app.basic;

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

        public async Task<GetAppsResponse> _getAppsBy(List<int> ids = null, List<string> codes = null, string name = null, List<int> spaceIds = null, int offset = 0, int limit = 100)
        {
            try
            {
                var getAppsRequest = new GetAppsRequest(ids, codes, name, spaceIds, offset, limit);
                var jsonBody = this.parser.ParseObjectToJson(getAppsRequest);
                var responseString = await this.connection.Request(ConnectionConstants.GET_REQUEST, ConnectionConstants.APPS, jsonBody);
                return this.parser.ParseJsonToObject<GetAppsResponse>(responseString);
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

        public async Task<AppModel> getApp(int appId)
        {
            try
            {
                var getAppRequest = new GetAppRequest(appId);
                var jsonBody = this.parser.ParseObjectToJson(getAppRequest);
                var responseString = await this.connection.Request(ConnectionConstants.GET_REQUEST, ConnectionConstants.APP, jsonBody);
                return this.parser.ParseJsonToObject<AppModel>(responseString);
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

        public async Task<GetAppsResponse> getApps(int offset, int limit)
        {
            try
            {
                return await this._getAppsBy(offset: offset, limit: limit);
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

        public async Task<GetAppsResponse> getAppsByIDs(List<int> ids, int offset, int limit)
        {
            try
            {
                return await this._getAppsBy(ids: ids, offset: offset, limit: limit);
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

        public async Task<GetAppsResponse> getAppsByCodes(List<string> codes, int offset, int limit)
        {
            try
            {
                return await this._getAppsBy(codes: codes, offset: offset, limit: limit);
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

        public async Task<GetAppsResponse> getAppsByName(string name, int offset, int limit)
        {
            try
            {
                return await this._getAppsBy(name: name, offset: offset, limit: limit);
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

        public async Task<GetAppsResponse> getAppsBySpaceIDs(List<int> spaceIds, int offset, int limit)
        {
            try
            {
                return await this._getAppsBy(spaceIds: spaceIds, offset: offset, limit: limit);
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

        public async Task<PreviewApp> addPreviewApp(string name, int space, int thread)
        {
            try
            {
                var addPreviewAppRequest = new AddPreviewAppRequest(name, space, thread);
                var jsonBody = this.parser.ParseObjectToJson(addPreviewAppRequest);
                var responseString = await this.connection.Request(ConnectionConstants.POST_REQUEST, ConnectionConstants.APP_PREVIEW, jsonBody);
                return this.parser.ParseJsonToObject<PreviewApp>(responseString);
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
