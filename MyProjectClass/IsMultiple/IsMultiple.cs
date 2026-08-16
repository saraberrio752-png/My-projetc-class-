using Shared;
using static System.Runtime.InteropServices.JavaScript.JSType;
var answer = "Yes";
var options = new List<string> { "Yes", "Not" };

do
{
    var Num1 = ConsoleExtension.GetInt("Enter the first number: ");
    var Num2 = ConsoleExtension.GetInt("Enter the second number: ");
    if (Num2 % Num1 == 0)
    {
        Console.WriteLine($"The number {Num1} is a multiple of {Num2}");
    }
    else
    {
        Console.WriteLine($"The number {Num1} is not a multiple of {Num2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Do you want to continue [ Yes ] or [ Not ]?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("Yes", StringComparison.CurrentCultureIgnoreCase));

    Console.WriteLine("Game Over.");
