using System;
using Newtonsoft.Json;
namespace kintoneDotNetSDK.model.app.form.field.input.lookup
{
    public class LookupField: AbstractInputField
    {
        [JsonProperty("lookup")]
        private LookupItem lookup;

        public LookupField(string code, FieldType type)
        {
            this.type = type;
            this.code = code;
        }

        public LookupItem getLookup()
        {
            return this.lookup;
        }

        public void setLookup(LookupItem lookup)
        {
            this.lookup = lookup;
        }

        public void setType(FieldType type)
        {
            this.type = type;
        }
    }
}
