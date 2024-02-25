using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class Helper
    {
        /// <summary>
        /// кастомное сравнение
        /// </summary>
        public static Func<object, object, bool> isEquals = (obj, obj2) =>
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                var value = prop.GetValue(obj);
                var value2 = prop.GetValue(obj2, null);

                if (!value.Equals(value2))
                    return false;
            }
            return true;
        };
    }
}
