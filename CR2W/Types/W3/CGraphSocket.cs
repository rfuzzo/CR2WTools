
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CGraphSocket : ISerializable
	{
		[W3Type("block")]
		public Ptr<CGraphBlock> Block { get; set; }

		[W3Type("name")]
		public CName Name { get; set; }

		[W3Type("connections")]
		public Array<Ptr<CGraphConnection>> Connections { get; set; }

	}
}
