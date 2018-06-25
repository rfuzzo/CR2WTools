
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CHudModuleResourceBlock : CGraphBlock, IGuiResourceBlock
    {
		[REDProp("moduleName")]
		public string ModuleName { get; set; }

		[REDProp("moduleClass")]
		public CName ModuleClass { get; set; }

	}
}
