using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class CalculatedField: AbstractInputField
    {
        [JsonProperty("expression")]
        private string expression;
        [JsonProperty("hideExpression")]
        private bool hideExpression;
        [JsonProperty("displayScale")]
        private int displayScale;
        [JsonProperty("unit")]
        private string unit;
        [JsonProperty("unitPosition")]
        private UnitPosition unitPosition;
        [JsonProperty("format")]
        private NumberFormat format;

        public CalculatedField()
        {
            this.type = FieldType.CALC;
        }

        public CalculatedField(string code)
        {
            this.code = code;
            this.type = FieldType.CALC;
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

        public int getDisplayScale()
        {
            return this.displayScale;
        }

        public void setDisplayScale(int displayScale)
        {
            this.displayScale = displayScale;
        }

        public string getUnit()
        {
            return this.unit;
        }

        public void setUnit(string unit)
        {
            this.unit = unit;
        }

        public UnitPosition getUnitPosition()
        {
            return this.unitPosition;
        }

        public void setUnitPosition(UnitPosition unitPosition)
        {
            this.unitPosition = unitPosition;
        }

        public NumberFormat getFormat()
        {
            return this.format;
        }

        public void setFormat(NumberFormat format)
        {
            this.format = format;
        }
    }
}
