using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.basic
{
    public class PreviewApp
    {
        [JsonProperty("app")]
        private string app;

        [JsonProperty("revision")]
        private string revision;

        public int getApp()
        {
            int defaultAppId;
            int.TryParse(this.app, out defaultAppId);
            return defaultAppId;
        }
        public void setApp(int app)
        {
            this.app = app.ToString();
        }

        public int getRevision()
        {
            int defaultRevision;
            int.TryParse(this.revision, out defaultRevision);
            return defaultRevision;
        }

        public void setRevision(int revision)
        {
            this.revision = revision.ToString();
        }

        public PreviewApp(string app, string revision)
        {
            this.app = app;
            this.revision = revision;
        }
    }
}
