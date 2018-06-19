
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuBackgroundVideoAliasParam : CObject, IMenuBackgroundVideoParam
	{
		[W3Type("videoAlias")]
		public CName VideoAlias { get; set; }

	}
}
