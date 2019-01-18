using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.related_record
{
    public class RelatedRecordsField: Field
    {
        [JsonProperty("label")]
        protected string label;
        [JsonProperty("noLabel")]
        protected bool noLabel;
        [JsonProperty("referenceTable")]
        protected ReferenceTable referenceTable;

        public RelatedRecordsField(string code)
        {
            this.code = code;
            this.type = FieldType.REFERENCE_TABLE;
        }

        public string getLabel()
        {
            return this.label;
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

        public ReferenceTable getReferenceTable()
        {
            return this.referenceTable;
        }

        public void setReferenceTable(ReferenceTable referenceTable)
        {
            this.referenceTable = referenceTable;
        }
    }
}
