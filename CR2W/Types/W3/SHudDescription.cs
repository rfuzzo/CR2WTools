
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SHudDescription
	{
		[REDProp("hudName")]
		public CName HudName { get; set; }

		[REDProp("hudResource")]
		public Soft<CHudResource> HudResource { get; set; }

	}
}