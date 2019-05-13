using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InDepth.Chapters;

namespace InDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpt2 = new Chapter2();
            cpt2.TestTypeOf<int>();// type inference 
        }
    }
}
