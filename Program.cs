using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = {1,3,2,4};

            


            long n = A.Length + 1;

            var sumOfAllElements = (n * (1 + n)) / 2;
            var missingElement = sumOfAllElements - A.Select(x => (long)x).Sum();
            //return (int)missingElement ; 

            Console.WriteLine((int)missingElement);
            Console.ReadKey();


        }
    }
}
