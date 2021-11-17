using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negative.Common.ExtensionMethods
{
    public static class TypeExtensions
    {
        public static T CreateInstance<T>(this Type t, params object[] paramArray)
        {
            return (T)Activator.CreateInstance(t, paramArray);
        }
    }
}
