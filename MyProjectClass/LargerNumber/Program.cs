using System.ComponentModel.Design;
string? numberstringA=String.Empty;
string? numberstringB=String.Empty;
string? numberstringC= String.Empty;
do
{
    int numbera = 0;
    int numberb = 0;
    int numberc = 0;

    Console.WriteLine("Enter 3 different integers or the word 'EXIT': ");
    numberstringA = Console.ReadLine();
    if (numberstringA!.ToUpper() == "EXIT")
    {
        continue;
    }
    numberstringB = Console.ReadLine();
    if (numberstringB!.ToUpper() == "EXIT")
    {
        continue;
    }
    numberstringC = Console.ReadLine();
    if (numberstringC!.ToUpper() == "EXIT")
    {
        continue;
    }
    if (int.TryParse(numberstringA, out int a))
    {
        numbera = a;
    }

    if (int.TryParse(numberstringB, out int b))
    {
        numberb = b;
    }

    if (int.TryParse(numberstringC, out int c))
    {
        numberc = c;
    }

    if (numbera > numberb && numbera > numberc)
    {
        Console.WriteLine($" The number {numbera} is the largest number ");
    }
    else
        if (numberb > numbera && numberb > numberc)
        {
            Console.WriteLine($" The number {numberb} is the largest number ");
        }
        else
        {
            Console.WriteLine($" The number {numberc} is the largest number ");
        }

} while (numberstringA!.ToUpper() != "EXIT"
         && numberstringB!.ToUpper() != "EXIT"
          && numberstringC!.ToUpper() != "EXIT");
Console.WriteLine("! Has ended ¡");
