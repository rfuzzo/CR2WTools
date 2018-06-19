
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SMenuDescription
	{
		[W3Type("menuName")]
		public CName MenuName { get; set; }

		[W3Type("menuResource")]
		public Soft<CMenuResource> MenuResource { get; set; }

	}
}
