using System;
namespace kintoneDotNetSDK.model.app.form.field.input.member
{
    public class UserSelectionField : AbstractMemberSelectField
    {
        public UserSelectionField(string code)
        {
            this.code = code;
            this.type = FieldType.USER_SELECT;
        }
    }
}
