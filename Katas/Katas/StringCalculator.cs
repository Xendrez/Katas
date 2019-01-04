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

            return Convert.ToInt32(input);
        }
    }
}
