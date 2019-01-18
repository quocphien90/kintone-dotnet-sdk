using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public class FieldLayout
    {
        [JsonProperty("type")]
        private string type;
        [JsonProperty("code")]
        private string code;
        [JsonProperty("elementId")]
        private string elementId;
        [JsonProperty("label")]
        private string label;
        [JsonProperty("size")]
        private FieldSize size;

        public string getType()
        {
            return this.type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public string getElementId()
        {
            return this.elementId;
        }

        public void setElementId(string elementId)
        {
            this.elementId = elementId;
        }

        public string getLabel()
        {
            return this.label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }

        public FieldSize getSize()
        {
            return this.size;
        }

        public void setSize(FieldSize size)
        {
            this.size = size;
        }
    }
}
