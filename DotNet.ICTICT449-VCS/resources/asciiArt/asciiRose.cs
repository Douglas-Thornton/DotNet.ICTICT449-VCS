using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS.resources.asciiArt
{
	internal class asciiRose : IAscii
	{
        string art = @"
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

		void IAscii.PrintAscii()
		{
            Console.WriteLine(art);
		}
	}

    
}
