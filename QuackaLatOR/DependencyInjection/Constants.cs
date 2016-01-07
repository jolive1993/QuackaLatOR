using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public static class Constants
    {
        public static char[] acceptedoperators = Reflection.getOperators();
        public static bool findOperators(string s)
        {
            char c = s[0];
            return acceptedoperators.Contains(c);
        }
    }
}
