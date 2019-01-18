using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class MultiLineTextField: AbstractInputField
    {
        [JsonProperty("defaultValue")]
        private string defaultValue;
        public MultiLineTextField(string code)
        {
            this.type = FieldType.MULTI_LINE_TEXT;
            this.code = code;
        }

        public string getDefaultValue()
        {
            return this.defaultValue;
        }

        public void setDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
        }
    }
}
