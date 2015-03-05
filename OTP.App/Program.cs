using System;
using System.Threading;

namespace OTP.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a UserId: ");
            string secret = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Generated password for {0} at {1}: {2} ", secret, DateTime.Now, Lib.OTP.GetTotp(secret));
                Thread.Sleep(1000 * 3);
            }
        }
    }
}
