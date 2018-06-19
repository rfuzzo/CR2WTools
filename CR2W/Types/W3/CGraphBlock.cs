
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CGraphBlock : CObject
    {
		[W3Type("sockets")]
		public Array<Ptr<CGraphSocket>> Sockets { get; set; }

	}
}
