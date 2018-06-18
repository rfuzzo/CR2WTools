
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SPopupDescription
	{
		[W3Type("popupName")]
		public CName PopupName { get; set; }

		[W3Type("popupResource")]
		public Soft<CPopupResource> PopupResource { get; set; }

	}
}
