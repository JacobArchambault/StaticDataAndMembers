﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate = 0.04;

        // A static property.
        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }

        // A constructor.
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // A static constructor
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }
    }
}
