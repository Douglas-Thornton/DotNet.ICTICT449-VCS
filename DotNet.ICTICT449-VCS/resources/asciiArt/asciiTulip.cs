using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS.resources.asciiArt
{
	internal class asciiTulip : IAscii
	{
		string art = @"
         .-==-.
        /{.=-.}\
       | / .  \ |
       |;   :  :|
       \(   :  )/
        `._'__.'
      |\   ||
      \ \  ||
       | | ||
       | | ||   /|
       \  \||  / /
        \ ||| | |
         | || | |
          \||/  /
           ||| /
           || |
           ||/
           ||";

		void IAscii.PrintAscii()
		{
			Console.WriteLine(art);
		}
	}
}
