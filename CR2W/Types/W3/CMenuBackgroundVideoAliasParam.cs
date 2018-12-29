
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CMenuBackgroundVideoAliasParam : CObject, IMenuBackgroundVideoParam
	{
		[REDProp("videoAlias")]
		public CName VideoAlias { get; set; }

	}
}
