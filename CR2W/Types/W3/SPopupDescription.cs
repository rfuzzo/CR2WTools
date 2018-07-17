
using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct SPopupDescription
    {
		[REDProp("popupName")]
		public CName PopupName { get; set; }

		[REDProp("popupResource")]
		public Soft<CPopupResource> PopupResource { get; set; }

	}
}
