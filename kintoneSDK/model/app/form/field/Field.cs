using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field
{
    public abstract class Field
    {
        [JsonProperty("code")]
        protected string code = "";
        [JsonProperty("type")]
        protected FieldType type;

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public FieldType getType()
        {
            return this.type;
        }
    }
}
