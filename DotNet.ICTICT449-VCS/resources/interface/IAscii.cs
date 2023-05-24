using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.ICTICT449_VCS.resources
{

	internal interface IAscii
	{
		string IName 
		{ 
			get; 
			set; 
		}
		string IAsciiArt
		{
			get;
			set;
		}

		void printArt(string optionalColour);
	}
}
