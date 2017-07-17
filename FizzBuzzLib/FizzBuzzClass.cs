using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzzClass
    {
        public int UpperBound { get; set; }
        public int FizzNum { get; set; }
        public int BuzzNum { get; set; }
        public string FizzStr { get; set; }
        public string BuzzStr { get; set; }

        public FizzBuzzClass()
        {
            UpperBound = 100;
            FizzNum = 3;
            BuzzNum = 5;
            FizzStr = "Fizz";
            BuzzStr = "Buzz";
        }

        public IEnumerable<string> FizzBuzz()
        {
            for (int i = 1; i <= UpperBound; ++i)
            {
                if (i % FizzNum == 0 && i % BuzzNum == 0)
                {
                    yield return i + " " + FizzStr + BuzzStr;
                }
                else if (i % FizzNum == 0)
                {
                    yield return i + " " + FizzStr;
                }
                else if (i % BuzzNum == 0)
                {
                    yield return i + " " + BuzzStr;
                }
                else
                {
                    yield return i+"";
                }
            }
        }
    }
}
