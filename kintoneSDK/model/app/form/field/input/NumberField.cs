using System;
using Newtonsoft.Json;

namespace kintoneDotNetSDK.model.app.form.field.input
{
    public class NumberField: AbstractInputField
    {
        [JsonProperty("displayScale")]
        private int displayScale;
        [JsonProperty("unit")]
        private string unit;
        [JsonProperty("unitPosition")]
        private UnitPosition unitPosition;
        [JsonProperty("digit")]
        private bool digit;
        [JsonProperty("maxValue")]
        private int maxValue;
        [JsonProperty("minValue")]
        private int minValue;
        [JsonProperty("defaultValue")]
        private string defaultValue;
        [JsonProperty("unique")]
        private bool unique;

        public NumberField(string code)
        {
            this.code = code;
            this.type = FieldType.NUMBER;
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

        public bool getDigit()
        {
            return this.digit;
        }

        public void setDigit(bool digit)
        {
            this.digit = digit;
        }

        public int getMaxValue()
        {
            return this.maxValue;
        }

        public void setMaxValue(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public int getMinValue()
        {
            return this.minValue;
        }

        public void setMinValue(int minValue)
        {
            this.minValue = minValue;
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

        public void setUnique(bool unique)
        {
            this.unique = unique;
        }
    }
}
