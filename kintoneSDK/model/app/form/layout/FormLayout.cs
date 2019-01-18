using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public class FormLayout
    {
        [JsonProperty("revision")]
        private string revision;
        [JsonProperty("layout")]
        private List<ItemLayout> layout = new List<ItemLayout>();

        public string getRevision()
        {
            return this.revision;
        }

        public void setRevision(string revision)
        {
            this.revision = revision;
        }

        public List<ItemLayout> getLayout()
        {
            return this.layout;
        }

        public void setLayout(List<ItemLayout> layout)
        {
            this.layout = layout;
        }
    }
}
