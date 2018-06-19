
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntityAppearance
	{
		[W3Type("name")]
		public CName Name { get; set; }

		[W3Type("voicetag")]
		public CName Voicetag { get; set; }

		[W3Type("appearanceParams")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CEntityTemplateParam>> AppearanceParams { get; set; }

		[W3Type("useVertexCollapse")]
		public bool UseVertexCollapse { get; set; }

		[W3Type("usesRobe")]
		public bool UsesRobe { get; set; }

		[W3Type("wasIncluded")]
		public bool WasIncluded { get; set; }

		[W3Type("includedTemplates")]
        [W3ArrayFlags(2, 0)]
        public Array<Handle<CEntityTemplate>> IncludedTemplates { get; set; }

		[W3Type("collapsedComponents")]
        [W3ArrayFlags(2, 0)]
        public Array<CName> CollapsedComponents { get; set; }

	}
}
