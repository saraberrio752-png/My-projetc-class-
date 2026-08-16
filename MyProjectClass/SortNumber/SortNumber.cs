using Shared;
var temp =0;
var answer = string.Empty;
var options = new List<string> { "Yes", "Not" };

do
{
    var Num1 = ConsoleExtension.GetInt("Enter 3 different integers: ");
    var Num2 = ConsoleExtension.GetInt();
    var Num3 = ConsoleExtension.GetInt();
    if(Num1 == Num2)
    {
        Console.WriteLine(" They must be different numbers; enter them again.");
            continue;
     }
    if (Num3 == Num2 || Num1 == Num3)
    {
        Console.WriteLine(" They must be different numbers;  enter them again.");
        continue;
    }

    if (Num2 > Num1)
    {
        temp = Num1;
        Num1 = Num2;
        Num2= temp;
    }
    if(Num3 > Num2) 
    {
        temp = Num2;
        Num2 = Num3;
        Num3 = temp;
    }

   if (Num2 > Num1)
    {
        temp = Num1;
        Num1 = Num2;
        Num2 = temp;
    }
    Console.WriteLine($"The order from greatest to least is: {Num1}, {Num2}, {Num3}");

do
{
    answer = ConsoleExtension.GetValidOptions("Do you want to continue [ Yes ] or [ Not ]?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("Yes", StringComparison.CurrentCultureIgnoreCase)) ;

Console.WriteLine("Game Over.");