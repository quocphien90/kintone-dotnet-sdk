using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.time
{
    public class DateField: AbstractInputField
    {
        [JsonProperty("unique")]
        protected bool unique;
        [JsonProperty("defaultValue")]
        protected string defaultValue;
        [JsonProperty("defaultNowValue")]
        protected bool defaultNowValue;

        public DateField(string code)
        {
            this.code = code;
            this.type = FieldType.DATE;
        }

        public bool getUnique()
        {
            return unique;
        }

        public void setUnique(bool unique)
        {
            this.unique = unique;
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
