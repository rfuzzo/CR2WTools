
using System;
using System.IO;

using CR2W.IO;

namespace CR2W.Types.W3
{
	public class CGraphSocket
	{
		[REDProp("block")]
		public Ptr<CGraphBlock> Block { get; set; }

		[REDProp("name")]
		public CName Name { get; set; }

		[REDProp("connections")]
		public Array<Ptr<CGraphConnection>> Connections { get; set; }
    }
}
