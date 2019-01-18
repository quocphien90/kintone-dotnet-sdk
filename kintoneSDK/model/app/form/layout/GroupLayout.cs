using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public class GroupLayout: ItemLayout
    {
        [JsonProperty("code")]
        private string code;
        [JsonProperty("layout")]
        private List<RowLayout> layout = new List<RowLayout>();
        public GroupLayout()
        {
            this.type = LayoutType.GROUP;
        }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public List<RowLayout> getLayout()
        {
            return this.layout;
        }

        public void setLayout(List<RowLayout> layout)
        {
            this.layout = layout;
        }
    }
}
