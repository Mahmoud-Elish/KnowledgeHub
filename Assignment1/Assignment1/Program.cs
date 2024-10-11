using Assignment1;

#region BankAccount
//var accountNumber = "1235678909876";
//var account = new BankAccount(accountNumber);
//account.Deposit(-63.9m);
//account.Withdrawal(65.9m);
//Console.WriteLine(account.Balance);
#endregion

#region Product
//var product = new Product();
//product.Name = "item cx";
//product.Price = 25m;
//product.StockQuantity = 9;
//Console.WriteLine(product.Price);
//Console.WriteLine(product.IsAvailable ? "Product IsAvailable" : "Product Is not Available");
//product.UpdateStockQuantity(-8);
#endregion

#region Car
var car = new Car() { Make = "BM BOWER", Model = "X6", Year = 2006 };
Console.WriteLine(car.Age);
Console.WriteLine(car.Mileage);
car.Drive(8);
Console.WriteLine(car.Mileage);
#endregion


