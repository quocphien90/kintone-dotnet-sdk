using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace kintoneDotNetSDK.exception
{
    public class KintoneAPIException : Exception
    {
        private string message = null;
        private int? httpErrorCode;
        private ErrorResponse errorResponse = null;
        //private var request: Array<BulkRequestItem>?
        private List<ErrorResponse> errorResponses = null;

        public KintoneAPIException(int httpErrorCode, ErrorResponse errorResponse)
        {
            this.message = errorResponse.GetMessage();
            this.httpErrorCode = httpErrorCode;
            this.errorResponse = errorResponse;
        }

        public KintoneAPIException(string message) : base(message)
        {
            this.message = message;
        }

        public int GetHttpErrorCode()
        {
            return this.httpErrorCode.Value;
        }

        public ErrorResponse GetErrorResponse()
        {
            return this.errorResponse;
        }

        public List<ErrorResponse> GetErrorResponses()
        {
            return this.errorResponses;
        }
    }
}
