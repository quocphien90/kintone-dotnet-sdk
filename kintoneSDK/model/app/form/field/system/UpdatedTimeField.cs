using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class UpdatedTimeField: AbstractSystemField
    {
        public UpdatedTimeField(string code)
        {
            this.code = code;
            this.type = FieldType.UPDATED_TIME;
        }
    }
}
