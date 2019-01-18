using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.selection
{
    public class OptionData
    {
        [JsonProperty("index")]
        protected int index;
        [JsonProperty("label")]
        protected string label;

        public OptionData(int index, string label)
        {
            this.index = index;
            this.label = label;
        }

        public int getIndex()
        {
            return this.index;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }

        public string getLabel()
        {
            return this.label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }
    }
}
