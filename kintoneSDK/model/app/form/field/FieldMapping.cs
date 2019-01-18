using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field
{
    public class FieldMapping
    {
        [JsonProperty("field")]
        private string field;
        [JsonProperty("relatedField")]
        private string relatedField;

        public FieldMapping(string field, string relatedFields)
        {
            this.field = field;
            this.relatedField = relatedFields;
        }

        public string getField()
        {
            return this.field;
        }

        public void setField(string field)
        {
            this.field = field;
        }

        public string getRelatedFields()
        {
            return this.relatedField;
        }

        public void setRelatedFields(string relatedFields)
        {
            this.relatedField = relatedFields;
        }
    }
}
