using System;
using System.Collections.Generic;
using kintoneDotNetSDK.model.app.form.field.input;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field
{
    public class SubTableField : Field
    {
        [JsonProperty("fields")]
        protected Dictionary<String, AbstractInputField> fields = new Dictionary<String, AbstractInputField>();
        public SubTableField()
        {
            this.type = FieldType.SUBTABLE;
        }

        public SubTableField(string code)
        {
            this.code = code;
            this.type = FieldType.SUBTABLE;
        }

        public Dictionary<string, AbstractInputField> getFields()
        {
            return this.fields;
        }

        public void setFields(Dictionary<string, AbstractInputField> fields)
        {
            this.fields = fields;
        }

        public void addField(AbstractInputField field)
        {
            if (field == null || field.getCode() == null || field.getCode().Trim().Length == 0)
            {
                return;
            }
            fields.Add(field.getCode(), field);
        }

        public void removeField(AbstractInputField field)
        {
            if (field == null || field.getCode() == null || field.getCode().Trim().Length == 0)
            {
                return;
            }
            fields.Remove(field.getCode());
        }
    }
}
