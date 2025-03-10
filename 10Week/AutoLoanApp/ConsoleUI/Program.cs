using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLoanLibrary.Models; 

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoLoanModel carLoan = new AutoLoanModel();   

            // Get loan amount 
            Console.Write("How much is the loan: ");
            string loanAmountText = Console.ReadLine();
            bool isValidLoanAmount = double.TryParse(loanAmountText, out double loanAmount);
            while (isValidLoanAmount == false)
            {
                Console.WriteLine("Invalid input. Please enter a valid loan amount");
                Console.Write("How much is the loan: ");
                loanAmountText = Console.ReadLine();
                isValidLoanAmount = double.TryParse(loanAmountText, out loanAmount);
            }


            // Get duration of the loan
            Console.Write("What is the duration of the loan: ");
            string loanDurationText = Console.ReadLine();
            bool isValidDuration = double.TryParse(loanDurationText, out double loanTerm);
            while (isValidDuration == false)
            {
                Console.WriteLine("Invalid input. Please enter a valid loan amount");
                Console.Write("What is the duration of the loan: ");
                loanDurationText = Console.ReadLine();
                isValidDuration = double.TryParse(loanDurationText, out loanTerm);
            }


           
        }
    }
}
