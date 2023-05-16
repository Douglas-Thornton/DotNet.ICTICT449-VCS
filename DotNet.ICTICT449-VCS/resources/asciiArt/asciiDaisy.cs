using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS.resources.asciiArt
{
	internal class asciiDaisy : IAscii
	{
		private string asciiName = "Daisy";

		public string IName  // read-write instance property
		{
			get => asciiName;
			set => asciiName = value;
		}

		private string ascii = @"⠀⠀                           
                             .-.
                       __   /   \   __
                      (  `'.\   /.'`  )
                       '-._.(;;;)._.-'
                       .-'  ,`""`,  '-.
                      (__.-'/   \'-.__)/)_
                            \   /\    / / )
                             '-'  |   \/.-')
                             ,    | .'/\'..)
                             |\   |/  | \_)
                             \ |  |   \_/
                              | \ /
                               \|/    _,
                                /  __/ /
                               | _/ _.'
                               |/__/
                                \";

		public string IAsciiArt  // read-write instance property
		{
			get => ascii;
			set => ascii = value;
		}
	}
}
