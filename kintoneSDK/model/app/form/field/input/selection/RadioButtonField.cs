using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.selection
{
    public class RadioButtonField : AbstractSelectionField
    {
        [JsonProperty("defaultValue")]
        protected string defaultValue;
        [JsonProperty("align")]
        protected AlignLayout align;

        public RadioButtonField(string code)
        {
            this.code = code;
            this.type = FieldType.RADIO_BUTTON;
        }

        public AlignLayout getAlign()
        {
            return this.align;
        }

        public void setAlign(AlignLayout align)
        {
            this.align = align;
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
