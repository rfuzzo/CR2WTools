
using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct SMenuDescription
    {
		[REDProp("menuName")]
		public CName MenuName { get; set; }

		[REDProp("menuResource")]
		public Soft<CMenuResource> MenuResource { get; set; }

	}
}
