using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.selection
{
    public class DropDownField: AbstractSelectionField
    {
        [JsonProperty("defaultValue")]
        protected string defaultValue;
        public DropDownField(string code)
        {
            this.code = code;
            this.type = FieldType.DROP_DOWN;
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
