using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class LinkField : AbstractInputField
    {
        [JsonProperty("defaultValue")]
        private string defaultValue;
        [JsonProperty("unique")]
        private bool unique;
        [JsonProperty("maxLength")]
        private int maxLength;
        [JsonProperty("minLength")]
        private int minLength;
        [JsonProperty("protocol")]
        private LinkProtocol protocol;

        public LinkField(string code)
        {
            this.code = code;
            this.type = FieldType.LINK;
        }

        public string getDefaultValue()
        {
            return this.defaultValue;
        }

        public void setDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
        }

        public bool getUnique()
        {
            return this.unique;
        }

        public void setUnique(bool unique)
        {
            this.unique = unique;
        }

        public int getMaxLength()
        {
            return this.maxLength;
        }

        public void setMaxLength(int maxLength)
        {
            this.maxLength = maxLength;
        }

        public int getMinLength()
        {
            return this.minLength;
        }

        public void setMinLength(int minLength)
        {
            this.minLength = minLength;
        }

        public LinkProtocol getProtocol()
        {
            return this.protocol;
        }

        public void setProtocol(LinkProtocol protocol)
        {
            this.protocol = protocol;
        }
    }
}
