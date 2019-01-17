using System;
using kintoneDotNetSDK.model.app.app;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace kintoneDotNetSDK.model.app.basic.response
{
    public class GetAppDeployStatusResponse
    {
        [JsonProperty("apps")]
        private AppDeployStatus[] apps;

        public AppDeployStatus[] getApps()
        {
            return this.apps;
        }
        public void SetApps(AppDeployStatus[] apps)
        {
            this.apps = apps;
        }
    }
}
