
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CGraphConnection : ISerializable
	{
		[REDProp("source")]
		public Ptr<CGraphSocket> Source { get; set; }

		[REDProp("destination")]
		public Ptr<CGraphSocket> Destination { get; set; }

		[REDProp("inactive")]
		public bool Inactive { get; set; }

	}
}
