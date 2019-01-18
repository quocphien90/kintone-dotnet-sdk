using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.selection
{
    public class AbstractSelectionField : AbstractInputField
    {
        [JsonProperty("options")]
        protected Dictionary<string, OptionData> options = new Dictionary<string, OptionData>();
        public Dictionary<string, OptionData> getOptions()
        {
            return this.options;
        }

        public void setOptions(Dictionary<string, OptionData> options)
        {
            this.options = options;
        }

        public void addOption(OptionData option)
        {
            if (option == null || option.getLabel() == null || option.getLabel().Trim().Length == 0)
            {
                return;
            }
            options.Add(option.getLabel(), option);
        }

        public void removeOption(OptionData option)
        {
            if (option == null || option.getLabel() == null || option.getLabel().Trim().Length == 0)
            {
                return;
            }
            options.Remove(option.getLabel());
        }
    }
}
