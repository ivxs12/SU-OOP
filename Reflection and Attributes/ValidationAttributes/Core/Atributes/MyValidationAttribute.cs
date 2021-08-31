using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Core.Atributes
{
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
