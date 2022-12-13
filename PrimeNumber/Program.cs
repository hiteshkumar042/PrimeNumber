using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation to access the primeCheckFn method 
            PrimeNum obj= new PrimeNum();
            obj.PrimeCheckFn();       

        }       

    }
}