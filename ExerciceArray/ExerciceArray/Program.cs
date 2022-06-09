ExerciceArray.Students[] array = new ExerciceArray.Students[10];

Console.WriteLine("How many students will choose a room?");
int rooms = int.Parse(Console.ReadLine());

for(int i = 1; i <= rooms; i++)
{
    Console.WriteLine($"Rent #{i}");
    Console.WriteLine("What is the name of the student?");
    string name = Console.ReadLine();
    Console.WriteLine("What is the email of the student?");
    string email = Console.ReadLine();
    Console.WriteLine("Which room?");
    int room = int.Parse(Console.ReadLine());
    array[room] = new ExerciceArray.Students { Name = name, Email = email };
}

Console.WriteLine("Occupied rooms:");
for(int i = 0; i < 10; i++)
{
    if(array[i] != null)
    {
        Console.WriteLine(i + ": " + array[i]);
    }
}
