using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.basic.request
{
    public class GetAppsRequest
    {
        [JsonProperty("ids")]
        private List<int> ids;

        [JsonProperty("codes")]
        private List<string> codes;

        [JsonProperty("name")]
        private string name;

        [JsonProperty("spaceIds")]
        private List<int> spaceIds;

        [JsonProperty("offset")]
        private int offset;

        [JsonProperty("limit")]
        private int limit;

        public GetAppsRequest(List<int> ids, List<string> codes, string name, List<int> spaceIds, int offset, int limit)
        {
            this.ids = ids;
            this.codes = codes;
            this.name = name;
            this.spaceIds = spaceIds;
            this.offset = offset;
            this.limit = limit;
        }
    }
}
