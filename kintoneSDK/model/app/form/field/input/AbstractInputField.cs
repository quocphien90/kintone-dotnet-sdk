using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public abstract class AbstractInputField: Field
    {
        [JsonProperty("label")]
        protected string label;
        [JsonProperty("noLabel")]
        protected bool noLabel;
        [JsonProperty("required")]
        protected bool required;

        public string getLabel()
        {
            return this.label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }

        public bool getNoLabel()
        {
            return this.noLabel;
        }

        public void setNoLabel(bool noLabel)
        {
            this.noLabel = noLabel;
        }

        public bool getRequired()
        {
            return this.required;
        }

        public void setRequired(bool required)
        {
            this.required = required;
        }
    }
}
