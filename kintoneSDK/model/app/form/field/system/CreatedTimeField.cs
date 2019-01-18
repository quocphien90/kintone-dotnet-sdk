using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class CreatedTimeField: AbstractSystemField
    {
        public CreatedTimeField(string code)
        {
            this.code = code;
            this.type = FieldType.CREATED_TIME;
        }
    }
}
