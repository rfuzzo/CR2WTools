
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntity : CNode
	{
		[W3Type("tags")]
		public TagList Tags { get; set; }

		[W3Type("transform")]
		public EngineTransform Transform { get; set; }

		[W3Type("transformParent")]
		public Ptr<CHardAttachment> TransformParent { get; set; }

		[W3Type("guid")]
		public CGUID Guid { get; set; }

		[W3Type("components")]
		public Array<Ptr<CComponent>> Components { get; set; }

		[W3Type("template")]
		public Handle<CEntityTemplate> Template { get; set; }

		[W3Type("streamingDataBuffer")]
		public SharedDataBuffer StreamingDataBuffer { get; set; }

		[W3Type("streamingDistance")]
		public UInt8 StreamingDistance { get; set; }

		[W3Type("entityStaticFlags")]
		public EEntityStaticFlags EntityStaticFlags { get; set; }

		[W3Type("autoPlayEffectName")]
		public CName AutoPlayEffectName { get; set; }

		[W3Type("entityFlags")]
		public UInt8 EntityFlags { get; set; }

	}
}
