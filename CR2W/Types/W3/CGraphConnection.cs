
using System;
using System.IO;

using CR2W.IO;

namespace CR2W.Types.W3
{
	public class CGraphConnection
	{
		[REDProp("source")]
		public Ptr<CGraphSocket> Source { get; set; }

		[REDProp("destination")]
		public Ptr<CGraphSocket> Destination { get; set; }

		[REDProp("inactive")]
		public bool Inactive { get; set; }
    }
}
