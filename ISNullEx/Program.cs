using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNullEx
{
    class Program
    {

        static void Main(string[] args)
        {

            string S1 = "Welocme to world of Friends";
            string S2 = "";
            string S3 = string.Empty;

            bool b1 = string.IsNullOrEmpty(S1);
            bool b2 = string.IsNullOrEmpty(S2);
            bool b3 = string.IsNullOrEmpty(S3);
            Console.WriteLine(b1);
            Console.ReadLine();
            Console.WriteLine(b2);
            Console.ReadLine();
            Console.WriteLine(b3);
            Console.ReadLine();

        }

    }
    
}
