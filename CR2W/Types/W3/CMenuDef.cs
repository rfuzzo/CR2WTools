
using System;


namespace CR2W.Types.W3
{
	public class CMenuDef : CObject
	{
		[REDProp("timeParam")]
		public Ptr<IMenuTimeParam> TimeParam { get; set; }

		[REDProp("backgroundVideoParam")]
		public Ptr<IMenuBackgroundVideoParam> BackgroundVideoParam { get; set; }

		[REDProp("renderParam")]
		public Ptr<IMenuDisplayParam> RenderParam { get; set; }

	}
}
