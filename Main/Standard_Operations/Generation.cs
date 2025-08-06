using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Standard_Operations
{
    internal class Generation
    {
        public static void Generations() 
        {
            var numbers = Enumerable.Range(1, 5); // 1, 2, 3, 4, 5

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var repeated = Enumerable.Repeat("Hello", 3); // "Hello", "Hello", "Hello"

            foreach (var s in repeated)
            {
                Console.WriteLine(s);
            }





        }

    }
}
