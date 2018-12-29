
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CGraphBlock : CObject
    {
		[REDProp("sockets")]
		public Array<Ptr<CGraphSocket>> Sockets { get; set; }

	}
}
