using System;
using kintoneDotNetSDK.model.member;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.member
{
    public class MemberSelectEntity
    {
        [JsonProperty("code")]
        private string code;
        [JsonProperty("type")]
        private MemberSelectEntityType type;

        public MemberSelectEntity(string code, MemberSelectEntityType type)
        {
            this.code = code;
            this.type = type;
        }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public MemberSelectEntityType getType()
        {
            return this.type;
        }

        public void setType(MemberSelectEntityType type)
        {
            this.type = type;
        }
    }
}
