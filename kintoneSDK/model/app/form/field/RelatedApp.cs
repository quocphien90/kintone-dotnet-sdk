using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field
{
    public class RelatedApp
    {
        [JsonProperty("app")]
        private string app;
        [JsonProperty("code")]
        private string code;

        public RelatedApp(string app, string code)
        {
            this.app = app;
            this.code = code;
        }

        public string getApp()
        {
            return this.app;
        }

        public void setApp(string app)
        {
            this.app = app;
        }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }
    }
}
