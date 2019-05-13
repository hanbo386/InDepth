using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDepth.Chapters
{
    class Chapter2
    {
        public void TestTypeOf<T>()
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(List<T>));
            Console.WriteLine(typeof(List<int>));
        }
    }

    
}
