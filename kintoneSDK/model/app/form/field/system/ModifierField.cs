using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class ModifierField:AbstractSystemField
    {
        public ModifierField(string code)
        {
            this.code = code;
            this.type = FieldType.MODIFIER;
        }
    }
}
