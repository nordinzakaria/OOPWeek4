// See https://aka.ms/new-console-template for more information
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many transaction today?");
        string numStr = Console.ReadLine();
        int num = Int32.Parse(numStr);  //cast from string to int


        // create TransactionList obj here
        // call init
        TransactionArray trans = new TransactionArray(num);
        //trans.Init(num);


        for (int i = 0; i < num; i++)
        {
            // creating an object (variable of a certain class type)
            Transaction transaction;
            transaction = new Transaction();

            /*
            Console.WriteLine("How many transaction today?");
            string dayStr = Console.ReadLine();
            int num = Int32.Parse(numStr);  //cast from string to int
            */

            transaction.setDate(new DateTime(2008, 6, 1));
            transaction.setVal(10.5f);

            trans.Add(transaction);  // add transaction to the list
        }


        trans.Display();  // print the list of transactions
    }

}