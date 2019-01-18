using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class CategoryField: AbstractSystemField
    {
        [JsonProperty("enabled")]
        protected bool enabled;
        public CategoryField(string code)
        {
            this.code = code;
            this.type = FieldType.CATEGORY;
        }
        public bool getEnabled()
        {
            return this.enabled;
        }
        public void setEnabled(bool enabled)
        {
            this.enabled = enabled;
        }
    }
}
