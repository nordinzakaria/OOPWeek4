using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionList
    {
    // data 
    private Transaction[] transactions; // transactions is an Array object
    private int numTransactions;

    // operations
    public void Init(int num) { transactions = new Transaction[num]; }

    // how to complete this?????
    public void Add(Transaction transaction) 
        {
            transactions[numTransactions] = transaction;
        }

    public void Display()
    {
        for (int i = 0; i < numTransactions; i++)
        {
            Console.WriteLine(transactions[i].ToString());
        }
    }

    }
