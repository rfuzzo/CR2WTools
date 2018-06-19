
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuBackgroundVideoFileParam : IMenuBackgroundVideoParam
	{
		[W3Type("videoFile")]
		public string VideoFile { get; set; }

	}
}
