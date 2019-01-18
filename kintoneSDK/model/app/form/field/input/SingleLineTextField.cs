using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class SingleLineTextField: AbstractInputField
    {
        [JsonProperty("expression")]
        private string expression;
        [JsonProperty("hideExpression")]
        private bool hideExpression;
        [JsonProperty("minLength")]
        private int minLength;
        [JsonProperty("maxLength")]
        private int maxLength;
        [JsonProperty("defaultValue")]
        private string defaultValue;
        [JsonProperty("unique")]
        private bool unique;

        public SingleLineTextField(string code)
        {
            this.code = code;
            this.type = FieldType.SINGLE_LINE_TEXT;
        }

        public int getMinLength()
        {
            return this.minLength;
        }

        public void setMinLength(int minLength)
        {
            this.minLength = minLength;
        }

        public int getMaxLength()
        {
            return this.maxLength;
        }

        public void setMaxLength(int maxLength)
        {
            this.maxLength = maxLength;
        }

        public string getExpression()
        {
            return this.expression;
        }

        public void setExpression(string expression)
        {
            this.expression = expression;
        }

        public bool getHideExpression()
        {
            return this.hideExpression;
        }

        public void setHideExpression(bool hideExpression)
        {
            this.hideExpression = hideExpression;
        }

        public string getDefaultValue()
        {
            return this.defaultValue;
        }

        public void setDefaultValue(string defaultValue)
        {
            this.defaultValue = defaultValue;
        }

        public bool getUnique()
        {
            return this.unique;
        }

        public void setUnique(bool isUnique)
        {
            this.unique = isUnique;
        }
    }
}
