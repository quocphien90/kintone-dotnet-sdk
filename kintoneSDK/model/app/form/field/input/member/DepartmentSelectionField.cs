using System;
namespace kintoneDotNetSDK.model.app.form.field.input.member
{
    public class DepartmentSelectionField: AbstractMemberSelectField
    {
        public DepartmentSelectionField(string code)
        {
            this.code = code;
            this.type = FieldType.ORGANIZATION_SELECT;
        }
    }
}
