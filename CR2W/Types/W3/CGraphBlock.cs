
using System;


namespace CR2W.Types.W3
{
	public class CGraphBlock : CObject
    {
		[REDProp("sockets")]
		public Array<Ptr<CGraphSocket>> Sockets { get; set; }

	}
}
