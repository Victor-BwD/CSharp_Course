ProductsCadastration.Products p;

p = new ProductsCadastration.Products();

Console.WriteLine("Enter products info:");
Console.WriteLine("Enter the product name:");
p.Name = Console.ReadLine();
Console.WriteLine("Enter the product price:");
p.Price = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the product quantity:");
p.Quantity = int.Parse(Console.ReadLine());

Console.WriteLine("The product {0} has a total value of {1}", p.Name, p.TotalValue());

Console.WriteLine("Do you want add more products in the quantity?");
string anwser = Console.ReadLine().ToUpper();

do
{
    Console.WriteLine("Enter the quantity:");
    p.AddProducts(int.Parse(Console.ReadLine()));
    Console.WriteLine("Do you want add more products in the quantity?");
    anwser = Console.ReadLine().ToUpper();
} while (anwser == "YES");

Console.WriteLine("The product {0} with quantity of {1} has value of {2}", p.Name, p.Quantity, p.TotalValue());

Console.WriteLine("Do you want remove some products?");
string remove = Console.ReadLine().ToUpper();

do
{
    Console.WriteLine("Enter the quantity:");
    p.RemoveProducts(int.Parse(Console.ReadLine()));
    Console.WriteLine("Do you want remove some products?");
    remove = Console.ReadLine().ToUpper();
} while (remove == "YES");


Console.WriteLine("The product {0} with quantity of {1} has value of {2}", p.Name, p.Quantity, p.TotalValue());
