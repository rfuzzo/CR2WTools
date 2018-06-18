
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SHudDescription
	{
		[W3Type("hudName")]
		public CName HudName { get; set; }

		[W3Type("hudResource")]
		public Soft<CHudResource> HudResource { get; set; }

	}
}
