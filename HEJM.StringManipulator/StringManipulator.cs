using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEJM.StringManipulator
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
