using System;
using System.Collections.Generic;
using kintoneDotNetSDK.model.app.app;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.basic.response
{
    public class GetAppsResponse
    {
        [JsonProperty("apps")]
        private List<AppModel> apps;

        public List<AppModel> getApps()
        {
            return this.apps;
        }
        public void setApps(List<AppModel> apps)
        {
            this.apps = apps;
        }
    }
}
