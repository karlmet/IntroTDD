using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
                return 0;
            else
            {
                var stringSplit = numbers.Split(',');
                var sum = 0;
                foreach(string nbr in stringSplit)
                {
                    int number = Convert.ToInt16(nbr);
                    sum += number;

                }

                return sum;
            }
               
        }

      public int Divide(string numbers)
        {
            var stringSplit = numbers.Split(',');
            var firstNumber = Convert.ToInt16(stringSplit[0]);
            var secondNumber = Convert.ToInt16(stringSplit[1]);

            return firstNumber/ secondNumber;

        }
    }
}
