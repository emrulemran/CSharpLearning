using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class CheckAllVowels
    {
        static void Main(string[] args)
        {

            string inputString = "audiometry";
            char[] charArray = { 'a', 'e', 'i', 'o', 'u' };


            for (int i = 0; i < charArray.Length; i++)
            {
                if (inputString.ToCharArray()[i] == charArray[charArray.Length - 1])
                {
                    Console.WriteLine("the input text has all the vowels");
                }
                else
                {
                    Console.WriteLine("the input text doesn't have all the vowels");
                    break;

                }
            }

        }
    }
}
