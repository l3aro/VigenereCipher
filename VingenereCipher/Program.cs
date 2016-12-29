using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VingenereCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            VingenereCipher vc = new VingenereCipher();
            string temp = vc.Encrypt("cipher");
            Console.WriteLine(temp);

            temp = vc.Decrypt(temp);

            Console.WriteLine(temp);


            Console.ReadKey();
        }
    }
}
