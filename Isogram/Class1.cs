using System;
using System.Linq;

namespace Isogram
{
    public class Class1
    {
        public static bool IsoGram(string inputStr)
        {
            string store = "";
            if (inputStr == "")
            {
                return true;
            }
            else
            {
                foreach (char c in inputStr)
                {
                    if (char.IsLetter(c))
                        store += c;
                }
            }
            var inputValueActualLength = store.Distinct().Count();
            var inputValueExpectedlength = store.Count();
            if (inputValueActualLength == inputValueExpectedlength)
            {
                return true;
            }
            else
                return false;
        }
    }
}
