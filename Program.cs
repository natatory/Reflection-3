using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRefl = new Refl();
            var reflStr = Reflection.ConcatStringMembers(myRefl);
            Console.WriteLine(reflStr);
            Console.ReadLine();
        }
    }
}
