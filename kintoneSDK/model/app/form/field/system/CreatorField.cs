using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class CreatorField: AbstractSystemField
    {
        public CreatorField(string code)
        {
            this.code = code;
            this.type = FieldType.CREATOR;
        }
    }
}
