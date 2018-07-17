
using System;


namespace CR2W.Types.W3
{
	public class CMenuBackgroundVideoAliasParam : CObject, IMenuBackgroundVideoParam
	{
		[REDProp("videoAlias")]
		public CName VideoAlias { get; set; }

	}
}
