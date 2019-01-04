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

            if (input.Contains("//"))
            {
                var delimiter = input[2];
                input = input.Remove(0, 4);
                input = input.Replace(delimiter, ',');
            }

            if (input.Contains(","))
            {
                input = input.Replace("\n", ",");
                var collection = input.Split(',');

                var exceptionDescription = new StringBuilder();

                foreach (var a in collection)
                {
                    if (Convert.ToInt32(a) < 0)
                    {
                        exceptionDescription = exceptionDescription.Length > 0 ?
                        exceptionDescription.Append(", " + a) :
                        exceptionDescription.Append(a);
                    }
                }

                if (exceptionDescription.Length > 0)
                    throw new ArgumentException($"Negatives not allowed: {exceptionDescription.ToString()}");

                collection.
                    Select(int.Parse).
                    ToList().
                    Sum();
            }

            return Convert.ToInt32(input);
        }
    }
}
