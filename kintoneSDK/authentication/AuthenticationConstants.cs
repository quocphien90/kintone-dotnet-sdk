using System;
namespace kintoneDotNetSDK.authentication
{
    public static class AuthenticationConstants
    {
        public static string HEADER_KEY_AUTH_PASSWORD = "X-Cybozu-Authorization";
        public static string HEADER_KEY_AUTH_APITOKEN = "X-Cybozu-API-Token";
        public static string HEADER_KEY_AUTH_BASIC = "Authorization";
        public static string AUTH_BASIC_PREFIX = "Basic ";
    }
}
