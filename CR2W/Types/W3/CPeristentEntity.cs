
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CPeristentEntity : CEntity
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
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CComponent>> Components { get; set; }

		[W3Type("template")]
		public Handle<CEntityTemplate> Template { get; set; }

		[W3Type("streamingDataBuffer")]
		public SharedDataBuffer StreamingDataBuffer { get; set; }

		[W3Type("streamingDistance")]
		public Byte StreamingDistance { get; set; }

		[W3Type("entityStaticFlags")]
		public EEntityStaticFlags EntityStaticFlags { get; set; }

		[W3Type("autoPlayEffectName")]
		public CName AutoPlayEffectName { get; set; }

		[W3Type("entityFlags")]
		public Byte EntityFlags { get; set; }

		[W3Type("idTag")]
		public IdTag IdTag { get; set; }

		[W3Type("isSaveable")]
		public bool IsSaveable { get; set; }

	}
}
