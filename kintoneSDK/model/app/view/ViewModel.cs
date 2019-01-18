using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace kintoneDotNetSDK.model.app.view
{
    public class ViewModel
    {
        [JsonProperty("builtinType")]
        private BuiltinType builtinType;

        [JsonProperty("date")]
        private string date;

        [JsonProperty("fields")]
        private List<string> fields;

        [JsonProperty("filterCond")]
        private string filterCond;

        [JsonProperty("html")]
        private string html;

        [JsonProperty("id")]
        private string id;

        [JsonProperty("index")]
        private string index;

        [JsonProperty("name")]
        private string name;

        [JsonProperty("pager")]
        private bool pager;

        [JsonProperty("sort")]
        private string sort;

        [JsonProperty("title")]
        private string title;

        [JsonProperty("type")]
        private ViewType type;

        public enum ViewType
        {
            LIST,
            CALENDAR,
            CUSTOM
        }

        public enum BuiltinType
        {
            ASSIGNEE
        }

        public BuiltinType getBuiltinType()
        {
            return this.builtinType;
        }

        public void setBuiltinType(BuiltinType builtinType)
        {
            this.builtinType = builtinType;
        }

        public string getDate()
        {
            return this.date;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public List<string> getFields()
        {
            return this.fields;
        }

        public void setFields(List<string> fields)
        {
            this.fields = fields;
        }

        public string getFilterCond()
        {
            return this.filterCond;
        }

        public void setFilterCond(string filterCond)
        {
            this.filterCond = filterCond;
        }

        public string getHtml()
        {
            return this.html;
        }

        public void setHtml(string html)
        {
            this.html = html;
        }

        public int getId()
        {
            int defaultID;
            int.TryParse(this.id, out defaultID);
            return defaultID;
        }

        public void setId(int id)
        {
            this.id = id.ToString();
        }

        public int getIndex()
        {
            int defaultIndex;
            int.TryParse(this.index, out defaultIndex);
            return defaultIndex;
        }

        public void setIndex(int index)
        {
            this.index = index.ToString();
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public bool getPager()
        {
            return this.pager;
        }

        public void setPager(bool pager)
        {
            this.pager = pager;
        }

        public string getSort()
        {
            return this.sort;
        }

        public void setSort(string sort)
        {
            this.sort = sort;
        }

        public string getTitle()
        {
            return this.title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public ViewType getType()
        {
            return this.type;
        }

        public void setType(ViewType type)
        {
            this.type = type;
        }

    }
}
