using System;
namespace kintoneDotNetSDK.model.file
{
    public class DownloadRequest
    {
        private string fileKey;
        public DownloadRequest(string fileKey)
        {
            this.fileKey = fileKey;
        }
    }
}
