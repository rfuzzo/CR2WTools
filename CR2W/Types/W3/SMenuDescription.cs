
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SMenuDescription
	{
		[REDProp("menuName")]
		public CName MenuName { get; set; }

		[REDProp("menuResource")]
		public Soft<CMenuResource> MenuResource { get; set; }

	}
}
