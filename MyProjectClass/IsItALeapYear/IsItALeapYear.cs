using Shared;
using System.Runtime.InteropServices;
var answer = "Yes";
var options = new List<string> { "Yes", "Not" };
var year = 0;

do {
    var CurrentYear = DateTime.Now.Year;
    var message = string.Empty;
    year = ConsoleExtension.GetInt("Enter the year: ");

    if ( CurrentYear < year)
    {
        message = "is going to";
    }
    else if (CurrentYear == year)
    {
        message = "is";
    }
    else
    {
        message = "was";
    }

    if(year % 4 == 0)
    {
        if (year % 100 == 0)
        {

            if (year % 400 == 0)
            {
                Console.WriteLine($"The year {year} yes {message} a leap year");
            }
            else
            {
                Console.WriteLine($"The year {year} not {message} a leap year");
            }
        }
        else
        {
            Console.WriteLine($"The year {year} yes {message} a leap year");
        }  
    }
    else
    {
        Console.WriteLine($"The year {year} not {message} a leap year");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Do you want to continue [ Yes ] or [ Not ]?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("Yes", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");