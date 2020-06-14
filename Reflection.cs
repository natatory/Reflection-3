using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection_3
{
    public static class Reflection
    {
        public static string ConcatStringMembers(object TestObject)
        {
            if (TestObject == null) return "";
            Type t = TestObject.GetType();
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.NonPublic
                | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;
            var outStrFields = t.GetFields(flags)
                .Where(f => f.FieldType == typeof(string))
                .Select(f => f.GetValue(TestObject).ToString());
            var outStrMethods = t.GetMethods(flags)
                .Where(m => m.ReturnType == typeof(string) && m.GetParameters().Count() == 0)
                .Select(m => m.Invoke(TestObject, null).ToString());
            var outElements = outStrFields.Concat(outStrMethods)
                .OrderByDescending(e => e.Count())
                .ThenBy(e => e);
            StringBuilder outStr = new StringBuilder();
            foreach (string s in outElements) outStr.Append(s + " ");
            return outStr.ToString();
        }
    }
}
