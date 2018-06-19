
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class Color
	{
		[W3Type("Red")]
		public UInt8 Red { get; set; }

		[W3Type("Green")]
		public UInt8 Green { get; set; }

		[W3Type("Blue")]
		public UInt8 Blue { get; set; }

		[W3Type("Alpha")]
		public UInt8 Alpha { get; set; }

	}
}
