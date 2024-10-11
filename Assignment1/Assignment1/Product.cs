using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1;

public class Product
{
    public string Name { get; set; }
    private decimal _price;
    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price cannot be negative");
            }
            else { _price = value; }
        }
    }
    private int _stockQuantity;
    public int StockQuantity {
        get => _stockQuantity;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("StockQuantity cannot be negative");
            }
            else { _stockQuantity = value; }
        }
    }
    public bool IsAvailable => StockQuantity > 0;
    public void UpdateStockQuantity(int quantity)
    {
        if (quantity < 0 && Math.Abs(quantity) > StockQuantity)
        {
            Console.WriteLine("Can not reduce stock less than zero");
        }
        else { StockQuantity += quantity; }        
    }
}
