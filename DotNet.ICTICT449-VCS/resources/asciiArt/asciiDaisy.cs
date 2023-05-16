using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS.resources.asciiArt
{
	internal class asciiDaisy : IAscii
	{
		string art = @"⠀⠀                           
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

		void IAscii.PrintAscii()
		{
			Console.WriteLine(art);
		}
	}
}
