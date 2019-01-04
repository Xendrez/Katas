using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class StringCalculator
    {
        static void Main(string[] args)
        {

        }
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            if (input.Contains(","))
            {
                var numbers = input.Split(',');
                return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
            }

            return Convert.ToInt32(input);
        }
    }
}
