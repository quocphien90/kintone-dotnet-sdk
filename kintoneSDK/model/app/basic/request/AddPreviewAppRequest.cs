using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.basic.request
{
    public class AddPreviewAppRequest
    {
        [JsonProperty("name")]
        private string name;

        [JsonProperty("space")]
        private int space;

        [JsonProperty("thread")]
        private int thread;

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getSpace()
        {
            return this.space;
        }

        public void setSpace(int space)
        {
            this.space = space;
        }

        public int getThread()
        {
            return this.thread;
        }

        public void setThread(int thread)
        {
            this.thread = thread;
        }

        public AddPreviewAppRequest(string name, int space, int thread)
        {
            this.name = name;
            this.space = space;
            this.thread = thread;
        }
    }
}
