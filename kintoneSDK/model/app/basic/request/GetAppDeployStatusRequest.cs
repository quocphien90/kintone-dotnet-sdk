using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace kintoneDotNetSDK.model.app.basic.request
{
    public class GetAppDeployStatusRequest
    {
        [JsonProperty("apps")]
        private int[] apps;

        public int[] GetApps()
        {
            return this.apps;
        }
        public void SetApps(int[] apps)
        {
            this.apps = apps;
        }

        public GetAppDeployStatusRequest(int[] apps)
        {
            this.apps = apps;
        }
    }
}
