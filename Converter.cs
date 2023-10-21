using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bin2Dec
{
    public class Converter
    {
        public static string ToDecimal(string binary)
        {
            if (!IsBinaryString(binary)) return "Wrong input given!";
            var temp = binary.ToArray();
            Array.Reverse(temp);
            var reversed = new string(temp);
            int result = 0;
            int actualNumber = 0;
            for(int i = 0; i < reversed.Length; ++i)
            {
                actualNumber = reversed[i] - '0';
                result += actualNumber * (int)Math.Pow(2, i);
            }

            return result.ToString();
        }

        private static bool IsBinaryString(string binary)
        {
            return Regex.IsMatch(binary, "^[01]+$");
        }
    }
}
