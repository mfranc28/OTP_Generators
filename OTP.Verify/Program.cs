using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTP.Verify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your UserID: ");
            string uId = Console.ReadLine();
            Console.WriteLine("Please enter given password: ");
            string password = Console.ReadLine();

            var verify = Lib.OTP.GetTotp(uId);

            if (verify == password)
            {
                Console.WriteLine("Password is OK.");
            }
            else
            {
                Console.WriteLine("Sorry yor password is expired. Try again.");
            }
        }
    }
}
