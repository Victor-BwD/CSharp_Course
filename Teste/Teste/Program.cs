List<int> list = new List<int> { 1, 2, 3, 4, 5};
List<int> par = new List<int>();
List<int> impar = new List<int>();

foreach (int obj in list)
{
    if(obj % 2 == 0)
    {
        par.Add(obj);
    }
    else
    {
        impar.Add(obj);
    }
}

    Console.WriteLine("{0}", string.Join(", ", list));
Console.WriteLine("{0}", string.Join(", ", par));
Console.WriteLine("{0}", string.Join(", ", impar));



