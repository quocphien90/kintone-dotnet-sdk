using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.selection
{
    public class CheckboxField: AbstractSelectionField
    {
        [JsonProperty("defaultValue")]
        protected List<string> defaultValue = new List<string>();
        [JsonProperty("align")]
        protected AlignLayout align;

        public CheckboxField()
        {
            this.type = FieldType.CHECK_BOX;
        }

        public CheckboxField(string code)
        {
            this.code = code;
            this.type = FieldType.CHECK_BOX;
        }

        public AlignLayout getAlign()
        {
            return this.align;
        }

        public void setAlign(AlignLayout align)
        {
            this.align = align;
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
