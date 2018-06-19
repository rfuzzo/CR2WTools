
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CComponentReference
	{
		[W3Type("name")]
		public string Name { get; set; }

		[W3Type("className")]
		public CName ClassName { get; set; }

	}
}
