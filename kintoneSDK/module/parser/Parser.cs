using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using kintoneDotNetSDK.exception;
using Newtonsoft.Json.Serialization;

namespace kintoneDotNetSDK.module.parser
{
    public class Parser
    {
        public string ParseObjectToJson<T>(T data)
        {
            try
            {
                return JsonConvert.SerializeObject(data, Formatting.Indented);
            }
            catch
            {
                throw new KintoneAPIException("parse error");
            }
        }

        public T ParseJsonToObject<T>(string jsonString)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch
            {
                throw new KintoneAPIException("parse error");
            }
        }
    }
}
