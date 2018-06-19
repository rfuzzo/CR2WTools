
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class IAttachment : CObject
	{
		[W3Type("parent")]
		public Ptr<CNode> Parent { get; set; }

		[W3Type("child")]
		public Ptr<CNode> Child { get; set; }

		[W3Type("isBroken")]
		public bool IsBroken { get; set; }

	}
}
