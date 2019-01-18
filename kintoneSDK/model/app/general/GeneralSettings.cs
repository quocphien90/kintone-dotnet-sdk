using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.general
{
    public class GeneralSettings
    {
        [JsonProperty("name")]
        private string name;
        [JsonProperty("description")]
        private string description;
        [JsonProperty("icon")]
        private Icon icon;
        [JsonProperty("theme")]
        private IconTheme theme;
        [JsonProperty("revision")]
        private int revision;

        public enum IconTheme
        {
            WHITE, RED, BLUE, GREEN, YELLOW, BLACK
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public Icon getIcon()
        {
            return icon;
        }

        public void setIcon(Icon icon)
        {
            this.icon = icon;
        }

        public IconTheme getTheme()
        {
            return theme;
        }

        public void setTheme(IconTheme theme)
        {
            this.theme = theme;
        }

        public int getRevision()
        {
            return this.revision;
        }

        public void setRevision(int revision)
        {
            this.revision = revision;
        }
    }
}
