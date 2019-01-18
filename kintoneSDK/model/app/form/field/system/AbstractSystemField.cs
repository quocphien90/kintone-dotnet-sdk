using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.system
{
    public abstract class AbstractSystemField : Field
    {
        [JsonProperty("label")]
        protected string label;
        public string getLabel()
        {
            return this.label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }
    }
}
