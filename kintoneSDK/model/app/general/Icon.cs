using System;
using kintoneDotNetSDK.model.file;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.general
{
    public class Icon
    {
        [JsonProperty("file")]
        private FileModel file;
        [JsonProperty("key")]
        private string key;
        [JsonProperty("type")]
        private IconType type;

        public enum IconType
        {
            FILE, PRESET
        }

        public Icon(FileModel file, string key, IconType type)
        {
            this.file = file;
            this.key = key;
            this.type = type;
        }

        public FileModel getFile()
        {
            return file;
        }

        public void setFile(FileModel file)
        {
            this.file = file;
        }

        public string getKey()
        {
            return key;
        }

        public void setKey(string key)
        {
            this.key = key;
        }

        public IconType getType()
        {
            return type;
        }

        public void setType(IconType type)
        {
            this.type = type;
        }
    }
}
