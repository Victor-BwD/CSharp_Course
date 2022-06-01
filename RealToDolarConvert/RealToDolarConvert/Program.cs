using DolarToRealConvert;

Console.WriteLine("What is the dollar price?");
float price = float.Parse(Console.ReadLine());

Console.WriteLine("How many dollars?");
float quantity = float.Parse(Console.ReadLine());

float result = CoinConverter.DolarToReal(quantity, price);

Console.WriteLine("The total value is: " + result);