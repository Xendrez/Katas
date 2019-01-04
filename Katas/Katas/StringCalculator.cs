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
                input = input.Replace("\n", ",");
                return input.Split(',').
                    Select(int.Parse).
                    ToList().
                    Sum();
            }

            return Convert.ToInt32(input);
        }
    }
}
