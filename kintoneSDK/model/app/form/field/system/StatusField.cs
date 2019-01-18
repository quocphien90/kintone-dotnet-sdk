using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class StatusField : AbstractSystemField
    {
        public StatusField(string code)
        {
            this.code = code;
            this.type = FieldType.STATUS;
        }
    }
}
