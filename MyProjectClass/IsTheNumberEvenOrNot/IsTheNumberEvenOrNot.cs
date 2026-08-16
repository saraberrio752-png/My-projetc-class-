using System;
string? numberstring;
do
{
    Console.Write("Enter an integer or the word 'EXIT': ");
     numberstring = Console.ReadLine();
    if (numberstring!.ToUpper() == "EXIT")
    {
        continue;
    }
    var numberint = 0;
    if (int.TryParse(numberstring, out numberint))

        if (numberint % 2 == 0)
        {
            Console.WriteLine($" The number {numberint} is even ");
        }
        else
        {
            Console.WriteLine($" The number {numberint} is odd ");
        }
    else
    {
        Console.WriteLine($" The number {numberstring} is not a whole number ");
    }

} while (numberstring!.ToUpper() != "EXIT");
Console.WriteLine("! Has ended ¡");


