
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SPopupDescription
	{
		[REDProp("popupName")]
		public CName PopupName { get; set; }

		[REDProp("popupResource")]
		public Soft<CPopupResource> PopupResource { get; set; }

	}
}
