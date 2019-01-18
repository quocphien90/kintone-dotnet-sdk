using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public class RowLayout: ItemLayout
    {
        [JsonProperty("fields")]
        private List<FieldLayout> fields = new List<FieldLayout>();
        public RowLayout()
        {
            this.type = LayoutType.ROW;
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
