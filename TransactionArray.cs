using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionArray
    {
    // data 
    private Transaction[] transactions; // transactions is an Array object
    private int numTransactions;

    // constructor -
    // 1) no return type
    // 2) name is that of the class
    // 3) usually used for initialization
    public TransactionArray() 
    {
        transactions = new Transaction[10];
    }

    public TransactionArray(int num)
    {
        transactions = new Transaction[num];
    }

    // operations
    public void Init(int num) { transactions = new Transaction[num]; }

    // how to complete this?????
    public void Add(Transaction transaction) 
        {
            transactions[numTransactions++] = transaction;
        }

    public void Display()
    {
        for (int i = 0; i < numTransactions; i++)
        {
            Console.WriteLine(transactions[i].getVal());
        }
    }

    }
