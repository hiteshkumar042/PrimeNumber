using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter a number to check prime: ");
            int num = Convert.ToInt32(Console.ReadLine());
           //0 and 1 are not a prime Numbers
            if (num==0 || num == 1)
            {
                flag = 1;// flagged 1 for non prime
            }
            //to check num is divisible by any numbers from 2 to num/2
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    //if is divisible by any number from 2 to num/2, flagged 1 for non prime
                    flag = 1;
                    break;//once it divisible any any one number no need to check for others
                }
            }
            if (flag == 0)//flagged 0 for prime numbers
            {
                Console.WriteLine("It is PrimeNumber");
            }
            else
            {
                Console.WriteLine("It is not a PrimeNumber");

            }       

        }       

    }
}