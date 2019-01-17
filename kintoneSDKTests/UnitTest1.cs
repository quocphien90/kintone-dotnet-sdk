using System;
using Xunit;
using kintoneDotNetSDK.connection;
using kintoneDotNetSDK.module.app;
using kintoneDotNetSDK.authentication;
using kintoneDotNetSDK.exception;
using System.Net.Http;

namespace kintoneDotNetSDKTests
{
    public class UnitTest1
    {
        private string USERNAME = "cybozu";
        private string PASSWORD = "cybozu";
        private string DOMAIN = "phienphamf19-2-1.cybozu-dev.com";
        private int[] APP_IDS = {5};
        private string[] APP_STATUS = { "PROCESSING", "SUCCESS", "FAIL", "CANCEL" };
        private App app = null;
        private Connection connection = null;

        [Fact]
        public async void Test1()
        {
            Auth auth = new Auth();
            auth = auth.SetPasswordAuth(this.USERNAME, this.PASSWORD);
            this.connection = new Connection(this.DOMAIN, auth);
            this.connection.SetProxy("dc-ty3-squid-1.cb.local", 3128);
            this.app = new App(this.connection);
            try
            {
                var response = await this.app.GetAppDeployStatus(null);
                Console.WriteLine(response);
            }
            catch (KintoneAPIException ex)
            {
                Console.WriteLine(ex.GetErrorResponse().GetMessage());
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }
    }
}
