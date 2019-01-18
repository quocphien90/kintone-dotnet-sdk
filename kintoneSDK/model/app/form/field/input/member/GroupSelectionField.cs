using System;
namespace kintoneDotNetSDK.model.app.form.field.input.member
{
    public class GroupSelectionField : AbstractMemberSelectField
    {
        public GroupSelectionField()
        {
            this.type = FieldType.GROUP_SELECT;
        }

        public GroupSelectionField(string code)
        {
            this.code = code;
            this.type = FieldType.GROUP_SELECT;
        }
    }
}
