using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Extensions
    {
        public static bool CustomsContains(this string word, string value)
        {
            return word.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) != -1;
        }
        public static string[] SplitCustom(this string @this, string separator, StringSplitOptions option)
        {
            return @this.Split(new[] { separator }, option);
        }
    }
}
