
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SEntityTemplateColoringEntry
	{
		[W3Type("appearance")]
		public CName Appearance { get; set; }

		[W3Type("componentName")]
		public CName ComponentName { get; set; }

		[W3Type("colorShift1")]
		public CColorShift ColorShift1 { get; set; }

		[W3Type("colorShift2")]
		public CColorShift ColorShift2 { get; set; }

	}
}
