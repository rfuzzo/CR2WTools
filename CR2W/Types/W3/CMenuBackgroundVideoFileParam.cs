
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CMenuBackgroundVideoFileParam : IMenuBackgroundVideoParam
	{
		[REDProp("videoFile")]
		public string VideoFile { get; set; }

	}
}
