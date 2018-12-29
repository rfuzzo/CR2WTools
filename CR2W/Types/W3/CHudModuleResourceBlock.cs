
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CHudModuleResourceBlock : CGraphBlock, IGuiResourceBlock
    {
		[REDProp("moduleName")]
		public string ModuleName { get; set; }

		[REDProp("moduleClass")]
		public CName ModuleClass { get; set; }

	}
}
