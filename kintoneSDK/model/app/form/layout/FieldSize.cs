using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.layout
{
    public class FieldSize
    {
        [JsonProperty("width")]
        private string width;
        [JsonProperty("height")]
        private string height;
        [JsonProperty("innerHeight")]
        private string innerHeight;

        public string getWidth()
        {
            return this.width;
        }

        public void setWidth(string width)
        {
            this.width = width;
        }

        public string getHeight()
        {
            return this.height;
        }

        public void setHeight(string height)
        {
            this.height = height;
        }

        public string getInnerHeight()
        {
            return this.innerHeight;
        }

        public void setInnerHeight(string innerHeight)
        {
            this.innerHeight = innerHeight;
        }
    }
}
