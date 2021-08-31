using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Core.Atributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
        public override bool IsValid(object obj)
        {
            if (obj is int)
            {
                int value = (int)obj;
                if (value <= maxValue && value >= minValue)
                {
                    return true;
                }
                return false;
            }
            throw new ArgumentException("Invalid data type");
        }

    }
}
