using System;
namespace kintoneDotNetSDK.model.member
{
    public class Member
    {
        public string code;
        public string name;

        public Member(string code, string name)
        {
            this.code = code;
            this.name = name;
        }

        public string getCode()
        {
            return this.code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }
}
