using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.basic.request
{
    public class GetAppRequest
    {
        [JsonProperty("id")]
        private int id;

        public GetAppRequest(int id)
        {
            this.id = id;
        }
    }
}
