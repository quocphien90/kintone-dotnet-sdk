using System;
namespace kintoneDotNetSDK.model.authentication
{
    public class Credential
    {
        private string username;
        private string password;

        public Credential(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUserName()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }
    }
}
