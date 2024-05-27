// See https://aka.ms/new-console-template for more information
using TaskFourAssignment.ObjectsFolder;

class Program
{
    static void Main(string[] args)
    {
        // Creating Banks objects
        Bank bankA = new BankA();
        Bank bankB = new BankB();
        Bank bankC = new BankC();

        // Calling getBalance method 
        Console.WriteLine("Balance in BankA: $" + bankA.GetBalance());
        Console.WriteLine("Balance in BankB: $" + bankB.GetBalance());
        Console.WriteLine("Balance in BankC: $" + bankC.GetBalance());
    }
}


