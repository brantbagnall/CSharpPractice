using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Classes;
using CSharpPractice.Interfaces;

namespace CSharpPractice
{
    class Program
    {

        static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            /* double[] numbers = new double[] { 1, 2, 3, 42, 42154 };
            var result = SimpleMath.Add(numbers); //using overload method
            Console.WriteLine(result);
            
            Console.WriteLine(bankAccount.Balance);

            ChildBankAccount childBankAccount = new ChildBankAccount();
            childBankAccount.AddToBalance(10);
            Console.WriteLine(childBankAccount.Balance); */

            ChildBankAccount bankAccount = new ChildBankAccount(); // creating an instances of non static BankAccount (non static means it is not autimatically loaded at startup)
            bankAccount.AddToBalance(100);

            SimpleMath simpleMath = new SimpleMath();

            Console.WriteLine(Information(bankAccount)); // passing in an implemented IInformation method

            Console.ReadLine();
        }

        private static string Information(IInformation information) // wants an implemented IInformation method
        {
            return information.GetInformation();
        }
    }

    class SimpleMath : IInformation
    {
        public static double Add(double n1, double n2) //normal method
        {
            return n1 + n2;
        }
        public static double Add(double[] numbers) //overload method can have as many as i want
        {
            double result = 0;
            foreach(double d in numbers)
            {
                result += d;
            }
            return result;
        }

        public string GetInformation()
        {
            return "Class that solves simple math.";
        }
    }
}
