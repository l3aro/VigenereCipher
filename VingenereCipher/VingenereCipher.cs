using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VingenereCipher
{
    class VingenereCipher
    {
        private string key { get; set; }

        public VingenereCipher()
        {
            key = "THISCRYPTOSYSTEMISNOTSECURE";
        }

        public string Encrypt(string raw)
        {
            string str = raw.ToUpper(); //chane text to upper case

            for (int i = str.Length; i < key.Length; i++)
            {
                str += str[(i % raw.Length)];
            }

            return str;

            //// bind string into an array of bytes
            //byte[] toAlphabetNumber = Encoding.ASCII.GetBytes(raw);

            //for (int index = 0; index < toAlphabetNumber.Length; index++)
            //{
            //    byte token = (byte)(toAlphabetNumber[index] - 65); // minus by 65 to back to Alphabet code context

            //    token = (byte)((a * token + b) % 26);

            //    token += 65; // plus by 65 to back to ASCII character

            //    toAlphabetNumber[index] = token;
            //}

            //// bind array into a string
            //string result = Encoding.ASCII.GetString(toAlphabetNumber);

            //return result;
        }
    }
}
