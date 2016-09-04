using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialListApp.Logic
{
    public class Factorial
    {
        public static IEnumerable<int> GetFactorials(int topBorder)
        {
            if (topBorder < 0)
                throw new ArgumentOutOfRangeException("topBorder", "Факториал определен только для неотрицательных целых чисел.");

            var factorials = new List<int>(topBorder);

            switch (topBorder)
            {
                case 0:
                    factorials.Add(0);
                    break;
                case 1:
                    factorials.Add(1);
                    break;
                default:
                    factorials.Add(1);
                    for (int i = 2; i <= topBorder; ++i)
                    {
                        factorials.Add(factorials[i - 2] * i);
                    }
                    break;
            }

            return factorials;
        }
    }
}
