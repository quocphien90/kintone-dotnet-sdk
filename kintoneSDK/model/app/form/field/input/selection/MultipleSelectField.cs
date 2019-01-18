using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.selection
{
    public class MultipleSelectField : AbstractSelectionField
    {
        [JsonProperty("defaultValue")]
        protected List<string> defaultValue = new List<string>();

        public MultipleSelectField(string code)
        {
            this.code = code;
            this.type = FieldType.MULTI_SELECT;
        }

        public List<string> getDefaultValue()
        {
            return this.defaultValue;
        }

        public void setDefaultValue(List<string> defaultValue)
        {
            this.defaultValue = defaultValue;
        }
    }
}
