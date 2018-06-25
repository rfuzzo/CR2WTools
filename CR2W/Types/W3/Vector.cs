
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class Vector
	{
		[REDProp("X")]
		public float X { get; set; }

		[REDProp("Y")]
		public float Y { get; set; }

		[REDProp("Z")]
		public float Z { get; set; }

		[REDProp("W")]
		public float W { get; set; }

	}
}
