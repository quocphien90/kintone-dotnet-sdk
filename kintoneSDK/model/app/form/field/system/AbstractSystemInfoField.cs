using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class AbstractSystemInfoField: AbstractSystemField
    {
        [JsonProperty("noLabel")]
        protected bool noLabel;

        public bool getNoLabel()
        {
            return this.noLabel;
        }

        public void setNoLabel(bool noLabel)
        {
            this.noLabel = noLabel;
        }
    }
}
