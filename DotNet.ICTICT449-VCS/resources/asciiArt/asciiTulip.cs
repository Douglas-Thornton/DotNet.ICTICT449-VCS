using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNet.ICTICT449_VCS.resources.asciiArt
{
	internal class asciiTulip : IAscii
	{
		private string asciiName = "Tulip";

		public string IName  // read-write instance property
		{
			get => asciiName;
			set => asciiName = value;
		}

		private string ascii = @"
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

		public string IAsciiArt  // read-write instance property
		{
			get => ascii;
			set => ascii = value;
		}
	}
}
