using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace kintoneDotNetSDK.model.app.app
{
    public class AppDeployStatus
    {
        [JsonProperty("app")]
        private string app;

        [JsonProperty("status")]
        private string _status;

        private string StatusEnum
        {
            set
            {
                if(Status.CANCEL.ToString().Equals(_status))
                {
                    value = Status.CANCEL.ToString();
                }
                else if (Status.FAIL.ToString().Equals(_status))
                {
                    value = Status.FAIL.ToString();
                }
                else if (Status.PROCESSING.ToString().Equals(_status))
                {
                    value = Status.PROCESSING.ToString();
                }
                else if (Status.SUCCESS.ToString().Equals(_status))
                {
                    value = Status.SUCCESS.ToString();
                }

            }
            get
            {
                return this._status;
            }
        }

        public enum Status {
            PROCESSING,
            SUCCESS,
            FAIL,
            CANCEL
        }
        public AppDeployStatus(int app, string status)
        {
            this.app = app.ToString();
            this._status = status;
        }

        public int GetApp(){
            int defaultAppID;
            int.TryParse(this.app,out defaultAppID);
            return defaultAppID;
        }
        public void SetApp(int app)
        {
            this.app = app.ToString();
        }
        public string GetStatus(){
            return this.StatusEnum;
        }
        public void SetStatus(string status)
        {
            this._status = status;
        }
    }
}
