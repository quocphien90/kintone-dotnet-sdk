using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input.member
{
    public abstract class AbstractMemberSelectField: AbstractInputField
    {
        [JsonProperty("defaultValue")]
        protected List<MemberSelectEntity> defaultValue = new List<MemberSelectEntity>();
        [JsonProperty("entites")]
        protected List<MemberSelectEntity> entites = new List<MemberSelectEntity>();

        public List<MemberSelectEntity> getDefaultValue()
        {
            return this.defaultValue;
        }

        public void setDefaultValue(List<MemberSelectEntity> defaultValue)
        {
            this.defaultValue = defaultValue;
        }

        public List<MemberSelectEntity> getEntites()
        {
            return this.entites;
        }

        public void setEntites(List<MemberSelectEntity> entites)
        {
            this.entites = entites;
        }
    }
}
