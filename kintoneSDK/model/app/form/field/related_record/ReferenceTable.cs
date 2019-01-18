using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.related_record
{
    public class ReferenceTable
    {
        [JsonProperty("condition")]
        private FieldMapping condition;
        [JsonProperty("filterCond")]
        private string filterCond;
        [JsonProperty("relatedApp")]
        private RelatedApp relatedApp;
        [JsonProperty("size")]
        private int size;
        [JsonProperty("displayFields")]
        private List<string> displayFields = new List<string>();
        [JsonProperty("sort")]
        private string sort;

        public ReferenceTable(FieldMapping condition, string filterCond, RelatedApp relatedApp, int size,
                List<string> displayFields)
        {
            this.condition = condition;
            this.filterCond = filterCond;
            this.relatedApp = relatedApp;
            this.size = size;
            this.displayFields = displayFields;
        }

        public FieldMapping getCondition()
        {
            return this.condition;
        }

        public void setCondition(FieldMapping condition)
        {
            this.condition = condition;
        }

        public string getFilterCond()
        {
            return this.filterCond;
        }

        public void setFilterCond(string filterCond)
        {
            this.filterCond = filterCond;
        }

        public RelatedApp getRelatedApp()
        {
            return this.relatedApp;
        }

        public void setRelatedApp(RelatedApp relatedApp)
        {
            this.relatedApp = relatedApp;
        }

        public int getSize()
        {
            return this.size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public List<string> getDisplayFields()
        {
            return this.displayFields;
        }

        public void setDisplayFields(List<string> displayFields)
        {
            this.displayFields = displayFields;
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
