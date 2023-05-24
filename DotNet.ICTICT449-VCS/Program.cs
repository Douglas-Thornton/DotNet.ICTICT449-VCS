using DotNet.ICTICT449_VCS.resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    private bool artTime = true;

    // GitSweats made this one!

    // Douglas Thornton made this change!

    static void Main(string[] args) => new Program().MainAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// The main function that starts the ASCII art console.
    /// </summary>
    public async Task MainAsync(string[] args)
    {
        var asciiItems = LoadAsiiArt();
        while (artTime)
        {
            ListUserOptions(asciiItems);

            ProcessUserInput(asciiItems);
        }

        ListUserOptions(asciiItems);

        // Block this task until the program is closed.
        //await Task.Delay(Timeout.Infinite);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<IAscii> LoadAsiiArt()
	{
        // Create a list that will contain classes that implement the IAscii interface.
        List<IAscii> asciiList = new List<IAscii>();

        // Get all types that implement IAscci
        var asciiClasses = GetImplementingTypesFromAssembly<IAscii>();

        var asciiItems = new List<IAscii>();

        // For each file that implements IAscii; instantiate them and add them to the list of ASCII items.
        foreach (var asciiClass in asciiClasses)
        {
            var ascii = (IAscii)Activator.CreateInstance(asciiClass);
            asciiItems.Add(ascii);
        }

		return asciiItems;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="asciiItems"></param>
    public void ListUserOptions(List<IAscii> asciiItems)
    {
        Console.WriteLine("Please select an option (like a flower) from the list:");

        foreach (var ascii in asciiItems)
        {
            // Read out the options of the class list.
            int index = asciiItems.FindIndex(a => a == ascii);
            Console.WriteLine(index + ": " + ascii.IName);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="asciiItems"></param>
    public void ProcessUserInput(List<IAscii> asciiItems)
    {
        var userInput = string.Empty;
        int value = -1;

        userInput = Console.ReadLine();

        if (userInput.Equals("e") || userInput.Equals("E"))
        {
            Console.WriteLine("Thank you for using this ASCII art program. We hope to see you again.\nRemember 9/10 dentist recommend this ASCII art program.");
            artTime = false;
        }
        else if (int.TryParse(userInput, out value))
        {
            try
            {
                if (value < 0 || value > asciiItems.Count)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("WOAH SOMETHING HAS GONE WRONG HERE, EITHER YOU HAVE ENTERED A NEGITIVE NUMBER OR THE ASCII OPTION IS NOT ON THE LIST!!!");
                    Console.WriteLine("You have to deal with this until the option is valid.");
                }
                else
                {
                    // If the number entered is contained within the list of items print the art into console.
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(asciiItems[value].IAsciiArt);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // If the element wasn't contained give the user an error.
                Console.WriteLine("Choice invalid. Please only enter a number from the list.");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Try again, that either wasn't a number (a literal number) or this program is broken...");
            Console.WriteLine("You have to deal with this until the option is valid.");
        }

        Console.WriteLine("Press any key to continue...");
    }



    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<Type> GetImplementingTypesFromAssembly<T>()
    {
        var interfaceType = typeof(T);
        var implementingTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => interfaceType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToList();

        return implementingTypes;
    }

}