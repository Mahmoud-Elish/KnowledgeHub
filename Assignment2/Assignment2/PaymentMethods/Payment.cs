using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2;

public class Payment(IPayment _paymentMethod)
{
    public void ExecutePayment(decimal amount)
    {
        _paymentMethod.ProcessPayment(amount);
    }
}
