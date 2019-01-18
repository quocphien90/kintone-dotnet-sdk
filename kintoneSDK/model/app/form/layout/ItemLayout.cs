using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public abstract class ItemLayout
    {
        [JsonProperty("type")]
        protected LayoutType type;
        public LayoutType getType()
        {
            return this.type;
        }
    }
}
