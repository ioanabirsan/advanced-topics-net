using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper
{
    public delegate string ProcessString(string s);

    class StringProcessingUtilities
    {
        public static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        public static string RemoveSpaces(string s)
        {
            return s.Replace(" ", "");
        }
    }
}
