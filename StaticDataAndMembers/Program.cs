﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            // Make an account.
            SavingsAccount s1 = new SavingsAccount(50);

            // Print the current interest rate via property.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);

            // Try to change the interest rate via property.
            SavingsAccount.InterestRate = 0.08;

            // Make a second account.
            SavingsAccount s2 = new SavingsAccount(100);

            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);
            Console.ReadLine();
        }
    }
}
