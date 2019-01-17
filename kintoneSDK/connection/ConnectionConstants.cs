using System;
namespace kintoneDotNetSDK.connection
{
    public static class ConnectionConstants
    {
        public static string BASE_URL = "/k/v1/{API_NAME}.json";
        public static string BASE_GUEST_URL = "/k/guest/{GUEST_SPACE_ID}/v1/{API_NAME}.json";
        public static string GET_REQUEST = "GET";
        public static string POST_REQUEST = "POST";
        public static string PUT_REQUEST = "PUT";
        public static string DELETE_REQUEST = "DELETE";
        public static string HTTPS_PREFIX = "https://";
        public static string USER_AGENT_KEY = "User-Agent";
        public static string USER_AGENT_VALUE = "kintone-dotnet-sdk";
        public static string CONTENT_TYPE_HEADER = "Content-Type";
        public static string METHOD_OVERRIDE_HEADER = "X-HTTP-Method-Override";
        public static string DEFAULT_CONTENT_TYPE = "application/octet-stream";
        public static string BOUNDARY = "boundary_aj8gksdnsdfakj342fs3dt3stk8g6j32";


        public static string APP = "app";
        public static string APP_CUSTOMIZE = "app/customize";
        public static string APP_CUSTOMIZE_PREVIEW = "preview/app/customize";
        public static string APP_DEPLOY = "review/app/deploy";
        public static string APP_DEPLOY_PREVIEW = "preview/app/deploy";
        public static string APP_FIELDS = "app/form/fields";
        public static string APP_FIELDS_PREVIEW = "preview/app/form/fields";
        public static string APP_LAYOUT = "app/form/layout";
        public static string APP_LAYOUT_PREVIEW = "preview/app/form/layout";
        public static string APP_PERMISSION = "app/acl";
        public static string APP_PERMISSION_PREVIEW = "preview/app/acl";
        public static string APP_PREVIEW = "preview/app";
        public static string APP_SETTINGS = "app/settings";
        public static string APP_SETTINGS_PREVIEW = "preview/app/settings";
        public static string APP_STATUS = "app/status";
        public static string APP_STATUS_PREVIEW = "preview/app/status";
        public static string APP_VIEWS = "app/views";
        public static string APP_VIEWS_PREVIEW = "preview/app/views";
        public static string APPS = "apps";
        public static string BULK_REQUEST = "bulkRequest";
        public static string FIELD_PERMISSION = "field/acl";
        public static string FILE = "file";
        public static string GUESTS = "guests";
        public static string RECORD = "record";
        public static string RECORD_ASSIGNEES = "record/assignees";
        public static string RECORD_COMMENT = "record/comment";
        public static string RECORD_COMMENTS = "record/comments";
        public static string RECORD_PERMISSION = "record/acl";
        public static string RECORD_STATUS = "record/status";
        public static string RECORDS = "records";
        public static string RECORDS_STATUS = "records/status";
        public static string SPACE = "space";
        public static string SPACE_BODY = "space/body";
        public static string SPACE_GUEST = "space/guests";
        public static string SPACE_MEMBER = "space/members";
        public static string SPACE_TEMPLATE = "template/space";
        public static string SPACE_THREAD = "space/thread";
        public static string SPACE_THREAD_COMMENT = "space/thread/comment";
    }
}
