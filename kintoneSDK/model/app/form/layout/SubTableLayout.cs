using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public class SubTableLayout: ItemLayout
    {
        [JsonProperty("code")]
        private string code;
        [JsonProperty("fields")]
        private List<FieldLayout> fields = new List<FieldLayout>();
        public SubTableLayout()
        {
            this.type = LayoutType.SUBTABLE;
        }


        public string getCode()
        {
            return this.code;
        }


        public void setCode(string code)
        {
            this.code = code;
        }


        public List<FieldLayout> getFields()
        {
            return this.fields;
        }


        public void setFields(List<FieldLayout> fields)
        {
            this.fields = fields;
        }
    }
}
