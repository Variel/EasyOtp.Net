using System;
using Variel.Security;

namespace Variel.Security.Otp.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Otp otp = new Otp("AASZQOWDXO");
            while(true)
                Console.WriteLine((string) otp.GetPassword());
        }
    }
}
