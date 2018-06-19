
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CComponent : CNode
	{
		[W3Type("tags")]
		public TagList Tags { get; set; }

		[W3Type("transform")]
		public EngineTransform Transform { get; set; }

		[W3Type("transformParent")]
		public Ptr<CHardAttachment> TransformParent { get; set; }

		[W3Type("guid")]
		public CGUID Guid { get; set; }

		[W3Type("name")]
		public string Name { get; set; }

		[W3Type("isStreamed")]
		public bool IsStreamed { get; set; }

	}
}
