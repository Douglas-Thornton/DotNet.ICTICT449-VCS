using DotNet.ICTICT449_VCS.resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

class Program
{
	public static List<Type> GetImplementingTypesFromAssembly<T>()
	{
		var interfaceType = typeof(T);
		var implementingTypes = Assembly.GetExecutingAssembly().GetTypes()
			.Where(t => interfaceType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
			.ToList();

		return implementingTypes;
	}

	static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {

            int? choice = null;
			
			// Create a list that will contain classes that implement the IAscii interface.
			List<IAscii> asciiList = new List<IAscii>();

			// Specify the folder path.
			string folderPath = "..\\..\\resources\\asciiArt";

			// Get all types that implement IAscci
			var asciiClasses = GetImplementingTypesFromAssembly<IAscii>();

			var asciiItems = new List<IAscii>();

			// Foreach file that implements IAscii; instantiate them and add them to the list of Assci items.
			foreach (var asciiClass in asciiClasses)
			{
				var ascii = (IAscii)Activator.CreateInstance(asciiClass);
				asciiItems.Add(ascii);
			}

			// Program loop.
			while (running)
            {
				Console.WriteLine("Select a flower from the list:");
                foreach (var ascii in asciiItems) 
                {
					// Read out the options of the class list.
					int index = asciiItems.FindIndex(a => a == ascii);
					Console.WriteLine(index + ": " + ascii.IName);
                }

				// Try to get a number from the user's imput.
				if (!int.TryParse(Console.ReadLine(), out int parsedValue)) 
                {
					// If this wasnt possible set choice to null.
                    choice = null;
                }
                else 
                {
					// Otherwise set choice to the selected value.
					choice = parsedValue;
				}

				// If choice wasnt null run program.
				if (choice != null)
                {
					try 
					{
						// If the number entered is contained within the list of items print the art into console.
						Console.WriteLine(asciiItems[choice.Value].IAsciiArt);

					}
					catch ( ArgumentOutOfRangeException ex)
					{
						// If the element wasn't contained give the user an error.
						Console.WriteLine("Choice invalid. Please only enter a number from the list.");
					}


					Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
				}
				else
				{
					// If the user's input wasnt able to be converted into a number give the user an error.
					Console.WriteLine("Choice invalid. Please only enter a number from the list.");
				}

			}
        }
    }
}