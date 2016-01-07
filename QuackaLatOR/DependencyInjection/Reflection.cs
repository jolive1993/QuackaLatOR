using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public static class Reflection
    {
        public static List<Type> filteredTypes;
        public static char[] getOperators()
        {
            Type[] types;
            types = System.Reflection.Assembly.Load("Operations").GetTypes();
            filteredTypes = new List<Type>();
            List<string> oper = new List<string>();
            List<char> operChars = new List<char>();
            foreach (Type t in types)
            {
                if(t.Name != "ICalculate")
                {
                    filteredTypes.Add(t);
                }
            }
            foreach (Type t in filteredTypes)
            {
                oper.Add(t.GetField("text").GetValue(null).ToString());
            }
            foreach (string s in oper)
            {
                operChars.Add(s[0]);
            }
            char[] operCharArray = new char[operChars.Count];
            operChars.CopyTo(operCharArray);
            return operCharArray;
        }
    }
}
