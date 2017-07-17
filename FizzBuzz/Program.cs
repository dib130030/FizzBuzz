using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzzLib.FizzBuzzClass(int.MaxValue);
            foreach (var line in fb.FizzBuzz())
            {
                Console.WriteLine(line);
            }
        }
    }
}
