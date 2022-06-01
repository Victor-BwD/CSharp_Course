WidthHeightTriangle.Triangle t;

t = new WidthHeightTriangle.Triangle();

Console.WriteLine("Triangle width: ");
t.Width = float.Parse(Console.ReadLine());
Console.WriteLine("Triangle height: ");
t.Height = float.Parse(Console.ReadLine());

Console.WriteLine("Triangle area: {0}", t.GetArea());
Console.WriteLine("Triangle perimeter: {0}", t.Perimeter());
Console.WriteLine("Triangle diagonal: {0}", t.Diagonal());
