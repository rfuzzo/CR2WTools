
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SEntityTemplateOverride
    {
        [W3Type("componentName")]
		public CName ComponentName { get; set; }

		[W3Type("className")]
		public CName ClassName { get; set; }

		[W3Type("overriddenProperties")]
        [W3ArrayFlags(2, 0)]
		public Array<CName> OverriddenProperties { get; set; }
	}
}
