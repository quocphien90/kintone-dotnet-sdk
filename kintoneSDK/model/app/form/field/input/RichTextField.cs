using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class RichTextField: AbstractInputField
    {
        [JsonProperty("defaultValue")]
        private string defaultValue;

        public RichTextField(string code)
        {
            this.code = code;
            this.type = FieldType.RICH_TEXT;
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
