using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_3
{
    public class Refl
    {
        public string str1 = "abcde";
        private string str2 = "abdcef";
        public string str3 = "abdc";
        public string str4 = "acb";
        public string str5 = "bac";
        public string str6 = "cba";
        private int int1 = 1;

        public string Output()
        {
            return "Test-Output";
        }

        public int AddInts(int i1, int i2)
        {
            return i1 + i2;
        }

        public string TonysLastname()
        {
            return "Stark";
        }
    }
}
