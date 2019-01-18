using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class AssigneeField: AbstractSystemField
    {
        public AssigneeField(string code)
        {
            this.code = code;
            this.type = FieldType.STATUS_ASSIGNEE;
        }
    }
}
