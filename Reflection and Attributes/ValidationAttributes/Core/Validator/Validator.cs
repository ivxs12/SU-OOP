using System.Reflection;
using ValidationAttributes.Core.Atributes;

namespace ValidationAttributes.Core.Validator
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute attribute = 
                    (MyValidationAttribute)property.GetCustomAttribute(typeof(MyValidationAttribute), false);
                if (!attribute.IsValid(property.GetValue(obj)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
