
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CColorShift
	{
		[W3Type("hue")]
		public UInt16 Hue { get; set; }

		[W3Type("saturation")]
		public SByte Saturation { get; set; }

		[W3Type("luminance")]
		public SByte Luminance { get; set; }

	}
}
