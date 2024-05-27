using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskFourAssignment.ObjectsFolder
{
    // Abstract class Bank
    public abstract class Bank
    {
        // Abstract method GetBalance
        public abstract double GetBalance();
    }

    // Class BankA from Bank
    public class BankA : Bank
    {
        private double balance = 100;   // field call

        // the abstract method GetBalance
        public override double GetBalance() // specifically to override an abstract or virtual method from a base class
        {
            return balance;
        }
    }

    // Class BankB from Bank
    public class BankB : Bank
    {
        private double balance = 150;   // field call

        // the abstract method GetBalance
        public override double GetBalance()
        {
            return balance;
        }
    }

    // Class BankC from Bank
    public class BankC : Bank
    {
        private double balance = 200;   // field call

        // the abstract method GetBalance
        public override double GetBalance()
        {
            return balance;
        }
    }
}