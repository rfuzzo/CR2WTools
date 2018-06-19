
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CHudModuleResourceBlock : CGraphBlock, IGuiResourceBlock
    {
		[W3Type("moduleName")]
		public string ModuleName { get; set; }

		[W3Type("moduleClass")]
		public CName ModuleClass { get; set; }

	}
}
