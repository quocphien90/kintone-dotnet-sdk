using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field
{
    public class FieldGroup : Field
    {
        [JsonProperty("label")]
        protected string label = null;
        [JsonProperty("noLabel")]
        protected bool noLabel;
        [JsonProperty("openGroup")]
        protected bool openGroup;

        public FieldGroup()
        {
            this.type = FieldType.GROUP;
        }

        public FieldGroup(string code)
        {
            this.code = code;
            this.type = FieldType.GROUP;
        }

        public string getLabel()
        {
            return label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }

        public bool getNoLabel()
        {
            return this.noLabel;
        }

        public void setNoLabel(bool noLabel)
        {
            this.noLabel = noLabel;
        }

        public bool getOpenGroup()
        {
            return this.openGroup;
        }

        public void setOpenGroup(bool openGroup)
        {
            this.openGroup = openGroup;
        }
    }
}
