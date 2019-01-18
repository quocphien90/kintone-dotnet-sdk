using System;
using kintoneDotNetSDK.model.member;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace kintoneDotNetSDK.model.app.app
{
    public class AppModel
    {
        [JsonProperty("appId")]
        private string appId;

        [JsonProperty("code")]
        private string code;

        [JsonProperty("name")]
        private string name;

        [JsonProperty("description")]
        private string description;

        [JsonProperty("spaceId")]
        private string spaceId;

        [JsonProperty("threadId")]
        private string threadId;

        [JsonProperty("createdAt")]
        private string createdAt;

        [JsonProperty("modifiedAt")]
        private string modifiedAt;

        [JsonProperty("modifier")]
        private Member modifier;

        [JsonProperty("creator")]
        private Member creator;

        public int getAppId()
        {
            int defaultAppID;
            int.TryParse(this.appId, out defaultAppID);
            return defaultAppID;
        }

        public void setAppId(int appId)
        {
            this.appId = appId.ToString();
        }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public int getSpaceId()
        {
            int defaultSpaceID;
            int.TryParse(this.spaceId, out defaultSpaceID);
            return defaultSpaceID;
        }

        public void setSpaceId(int spaceId)
        {
            this.spaceId = spaceId.ToString();
        }

        public int getThreadId()
        {
            int defaultThreadID;
            int.TryParse(this.threadId, out defaultThreadID);
            return defaultThreadID;
        }

        public void setThreadId(int threadId)
        {
            this.threadId = threadId.ToString();
        }

        public string getCreadtedAt()
        {
            return this.createdAt;
        }

        public void setCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
        }

        public Member getCreator()
        {
            return this.creator;
        }

        public void setCreator(Member creator)
        {
            this.creator = creator;
        }

        public string getModifiedAt()
        {
            return this.modifiedAt;
        }

        public void setModifiedAt(string modifiedAt)
        {
            this.modifiedAt = modifiedAt;
        }

        public Member getModifier()
        {
            return this.modifier;
        }

        public void setModifier(Member modifier)
        {
            this.modifier = modifier;
        }
    }
}
