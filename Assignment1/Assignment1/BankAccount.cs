using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1;

public class BankAccount
{
    public string AccountNumber { get;}
    public string AccountHolderName { get; set; }
    public decimal Balance { get; private set; }
    public BankAccount(string accountNumber)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
            Console.WriteLine("Account number cannot be empty");

        this.AccountNumber = accountNumber;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount can't less than zero");
            return;
        }
        Balance += amount;
    }
    public void Withdrawal(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount can't less than zero");
            return;
        }
           
        if (amount > Balance)
        {
            Console.WriteLine("Balance less than amount withdrawal");
            return;
        }      
        Balance -= amount;
    }
}
