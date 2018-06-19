
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class EulerAngles
	{
		[W3Type("Pitch")]
		public float Pitch { get; set; }

		[W3Type("Yaw")]
		public float Yaw { get; set; }

		[W3Type("Roll")]
		public float Roll { get; set; }

	}
}
