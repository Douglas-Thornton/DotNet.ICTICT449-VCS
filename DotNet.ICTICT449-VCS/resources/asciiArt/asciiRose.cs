using DotNet.ICTICT449_VCS.resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS.resources.asciiArt
{
	internal class asciiRose : IAscii
	{

		private string asciiName = "Rose";

		public string IName  // read-write instance property
		{
			get => asciiName;
			set => asciiName = value;
		}

		private string ascii = @"
    _,--._.-,
   /\_r-,\_ )
.-.) _;='_/ (.;
 \ \'     \/S )
  L.'-. _.'|-'
 <_`-'\'_.'/
   `'-._( \
    ___   \\,      ___
    \ .'-. \\   .-'_. /
     '._' '.\\/.-'_.'
        '--``\('--'
              \\
              `\\,
                \|";

		public string IAsciiArt  // read-write instance property
		{
			get => ascii;
			set => ascii = value;
		}

		public void printArt(string optionalColour)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                _,--._.-,
               /\_r-,\_ )
            .-.) _;='_/ (.;
             \ \'     \/S )
              L.'-. _.'|-'
             <_`-'\'_.'/
               `'-._(\");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"                     \\
                ___   \\,      ___
                \ .'-. \\   .-'_. /
                 '._' '.\\/.-'_.'
                    '--``\('--'
                          \\
                          `\\,
                            \|");
        }
	}
}