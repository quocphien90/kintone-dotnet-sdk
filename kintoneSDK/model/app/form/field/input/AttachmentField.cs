using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class AttachmentField : AbstractInputField
    {
        [JsonProperty("thumbnailSize")]
        protected int thumbnailSize;

        public AttachmentField(string code)
        {
            this.code = code;
            this.type = FieldType.FILE;
        }

        public int getThumbnailSize()
        {
            return this.thumbnailSize;
        }

        public void setThumbnailSize(int thumbnailSize)
        {
            this.thumbnailSize = thumbnailSize;
        }
    }
}
