using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2;

public class BankTransferPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"BankTransfer Payment = {amount}$");
    }
}
