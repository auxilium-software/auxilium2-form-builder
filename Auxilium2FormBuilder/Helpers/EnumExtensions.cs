using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Auxilium2FormBuilder.Helpers
{
    public static class EnumExtensions
    {
        public static string StringValue<T>(this T value)
            where T : Enum
        {
            var fieldName = value.ToString();
            var field = typeof(T).GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
            return field?.GetCustomAttribute<StringValueAttribute>()?.Value ?? fieldName;
        }
    }
}
