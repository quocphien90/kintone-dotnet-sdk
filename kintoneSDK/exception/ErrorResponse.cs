using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace kintoneDotNetSDK.exception
{
    public class ErrorResponse
    {
        [JsonProperty("message")]
        private string message = null;

        [JsonProperty("id")]
        private string id = null;

        [JsonProperty("code")]
        private string code = null;

        [JsonProperty("errors")]
        private Dictionary<string, Dictionary<string, List<string>>> errors = new Dictionary<string, Dictionary<string, List<string>>>();

        public ErrorResponse(string message, string id, string code, Dictionary<string, Dictionary<string, List<string>>> errors)
        {
            this.message = message;
            this.id = id;
            this.code = code;
            this.errors = errors;
        }

        public string GetMessage()
        {
            return this.message;
        }

        public void SetMessage(string message)
        {
            this.message = message;
        }

        public string GetId()
        {
            return this.id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }


        public string GetCode()
        {
            return this.code;
        }

        public void SetCode(string code)
        {
            this.code = code;
        }

        public Dictionary<string, Dictionary<string, List<string>>> GetErrors()
        {
            return this.errors;
        }

        public void SetErrors(Dictionary<string, Dictionary<string, List<string>>> errors)
        {
            this.errors = errors;
        }

        private ErrorResponse getErrorResponse(string jsonString)
        {
            JObject decoderJObject = new JObject();
            if (!String.IsNullOrEmpty(jsonString))
            {
                try
                {
                    decoderJObject = JObject.Parse(jsonString);
                    ErrorResponse errorResponse = decoderJObject.ToObject<ErrorResponse>();
                    return errorResponse;
                }
                catch
                {
                    return null;
                }
            }
            return null;

        }
    }
}