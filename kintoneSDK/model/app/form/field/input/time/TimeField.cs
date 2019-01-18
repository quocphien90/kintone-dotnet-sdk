using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.time
{
    public class TimeField : AbstractInputField
    {
        [JsonProperty("defaultValue")]
        protected string defaultValue;
        [JsonProperty("defaultNowValue")]
        protected bool defaultNowValue;

        public TimeField(string code)
        {
            this.code = code;
            this.type = FieldType.TIME;
        }

        public string getDefaultValue()
        {
            return defaultValue;
        }

        public void setDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
        }

        public bool getDefaultNowValue()
        {
            return defaultNowValue;
        }

        public void setDefaultNowValue(bool defaultNowValue)
        {
            this.defaultNowValue = defaultNowValue;
        }
    }
}
