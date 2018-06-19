
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CGraphConnection : ISerializable
	{
		[W3Type("source")]
		public Ptr<CGraphSocket> Source { get; set; }

		[W3Type("destination")]
		public Ptr<CGraphSocket> Destination { get; set; }

		[W3Type("inactive")]
		public bool Inactive { get; set; }

	}
}
