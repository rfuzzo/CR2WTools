
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class Color
	{
		[W3Type("Red")]
		public Byte Red { get; set; }

		[W3Type("Green")]
		public Byte Green { get; set; }

		[W3Type("Blue")]
		public Byte Blue { get; set; }

		[W3Type("Alpha")]
		public Byte Alpha { get; set; }

	}
}
