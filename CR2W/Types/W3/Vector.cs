
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class Vector
	{
		[W3Type("X")]
		public float X { get; set; }

		[W3Type("Y")]
		public float Y { get; set; }

		[W3Type("Z")]
		public float Z { get; set; }

		[W3Type("W")]
		public float W { get; set; }

	}
}
