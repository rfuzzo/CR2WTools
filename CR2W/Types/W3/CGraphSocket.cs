
using System;
using System.IO;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CGraphSocket
	{
		[REDProp("block")]
		public Ptr<CGraphBlock> Block { get; set; }

		[REDProp("name")]
		public CName Name { get; set; }

		[REDProp("connections")]
		public Array<Ptr<CGraphConnection>> Connections { get; set; }
    }
}
