using System;
namespace kintoneDotNetSDK.model.app.form.field.system
{
    public class RecordNumberField : AbstractSystemField
    {
        public RecordNumberField(string code)
        {
            this.code = code;
            this.type = FieldType.RECORD_NUMBER;
        }
    }
}
