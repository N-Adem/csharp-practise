using System;
using System.Collections;
using System.Linq;

namespace mathsOne
{

    public class Numbers
    {
        public static int ReturnPrime(int numberInput)
        {
            int[] listOfNums = Enumerable.Range(1,numberInput).ToArray();
            for(int i = 1; i <= listOfNums.Length; i++)
            {
                int tempval = numberInput/i;   
            }
            return 0;
        }
    }

    public class Fractions
    {

    }

}