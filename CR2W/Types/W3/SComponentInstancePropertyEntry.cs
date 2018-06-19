
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SComponentInstancePropertyEntry
	{
		[W3Type("component")]
		public CName Component { get; set; }

		[W3Type("property")]
		public CName Property { get; set; }

	}
}
