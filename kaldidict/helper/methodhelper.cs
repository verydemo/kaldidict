using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kaldidict
{
    public static class methodhelper
    {
        public static string[] splits(string str1, string str2)
        {

            return str1.Replace(str2, "^").Split('^');
        }
    }
}
