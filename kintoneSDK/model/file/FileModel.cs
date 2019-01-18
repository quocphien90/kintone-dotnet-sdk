using System;
namespace kintoneDotNetSDK.model.file
{
    public class FileModel
    {
        private string contentType;
        private string fileKey;
        private string name;
        private string size;

       
        public string getContentType()
        {
            return this.contentType;
        }

        public void setContentType(string contentType)
        {
            this.contentType = contentType;
        }

        public string getFileKey()
        {
            return this.fileKey;
        }

        public void setFileKey(string fileKey)
        {
            this.fileKey = fileKey;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSize()
        {
            return this.size;
        }

        public void setSize(string size)
        {
            this.size = size;
        }
    }
}
