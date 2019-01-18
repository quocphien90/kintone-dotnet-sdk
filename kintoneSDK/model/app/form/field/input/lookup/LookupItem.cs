using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace kintoneDotNetSDK.model.app.form.field.input.lookup
{
    public class LookupItem
    {
        [JsonProperty("fieldMappings")]
        private List<FieldMapping> fieldMappings = new List<FieldMapping>();
        [JsonProperty("filterCond")]
        private string filterCond;
        [JsonProperty("lookupPickerFields")]
        private List<string> lookupPickerFields = new List<String>();
        [JsonProperty("relatedApp")]
        private RelatedApp relatedApp;
        [JsonProperty("relatedKeyField")]
        private string relatedKeyField;
        [JsonProperty("sort")]
        private string sort;

        public List<FieldMapping> getFieldMapping()
        {
            return this.fieldMappings;
        }

        public void setFieldMapping(List<FieldMapping> fieldMapping)
        {
            this.fieldMappings = fieldMapping;
        }

        public string getFilterCond()
        {
            return this.filterCond;
        }

        public void setFilterCond(string filterCond)
        {
            this.filterCond = filterCond;
        }

        public List<String> getLookupPickerFields()
        {
            return this.lookupPickerFields;
        }

        public void setLookupPickerFields(List<String> lookupPickerFields)
        {
            this.lookupPickerFields = lookupPickerFields;
        }

        public RelatedApp getRelatedApp()
        {
            return this.relatedApp;
        }

        public void setRelatedApp(RelatedApp relatedApp)
        {
            this.relatedApp = relatedApp;
        }

        public string getRelatedKeyField()
        {
            return this.relatedKeyField;
        }

        public void setRelatedKeyField(string relatedKeyField)
        {
            this.relatedKeyField = relatedKeyField;
        }

        public string getSort()
        {
            return this.sort;
        }

        public void setSort(string sort)
        {
            this.sort = sort;
        }
    }
}
