
using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct SHudDescription
    {
		[REDProp("hudName")]
		public CName HudName { get; set; }

		[REDProp("hudResource")]
		public Soft<CHudResource> HudResource { get; set; }

	}
}