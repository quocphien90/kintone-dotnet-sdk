using System;
namespace kintoneDotNetSDK.model.http
{
    public class HTTPHeader
    {
        private string key;
        private string value;

        public HTTPHeader(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string GetKey()
        {
            return this.key;
        }

        public string GetValue()
        {
            return this.value;
        }
    }
}
