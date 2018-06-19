
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuDef : CObject
	{
		[W3Type("timeParam")]
		public Ptr<IMenuTimeParam> TimeParam { get; set; }

		[W3Type("backgroundVideoParam")]
		public Ptr<IMenuBackgroundVideoParam> BackgroundVideoParam { get; set; }

		[W3Type("renderParam")]
		public Ptr<IMenuDisplayParam> RenderParam { get; set; }

	}
}
