using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        private readonly int _upper;

        public FizzBuzzClass(int upper)
        {
            _upper = upper;
        }

        public IEnumerable<string> FizzBuzz()
        {
            for (int i = 1; i <= _upper; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return (i + " FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    yield return (i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    yield return (i + " Buzz");
                }
                else
                {
                    yield return (i.ToString());
                }
            }
        }
    }
}
