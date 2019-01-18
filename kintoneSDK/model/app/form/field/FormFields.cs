using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field
{
    public class FormFields
    {
        [JsonProperty("app")]
        private int app;
        [JsonProperty("revision")]
        private int revision;
        [JsonProperty("properties")]
        private Dictionary<String, Field> properties;

        public FormFields()
        {
            properties = new Dictionary<String, Field>();
        }


        public FormFields(int app, Dictionary<String, Field> properties, int revision)
        {
            this.app = app;
            this.revision = revision;
            this.properties = properties;
        }

        public int getApp()
        {
            return this.app;
        }

        public void setApp(int app)
        {
            this.app = app;
        }

        public int getRevision()
        {
            return this.revision;
        }

        public void setRevision(int revision)
        {
            this.revision = revision;
        }

        public Dictionary<String, Field> getProperties()
        {
            return this.properties;
        }


        public void setProperties(Dictionary<String, Field> properties)
        {
            this.properties = properties;
        }
    }
}
