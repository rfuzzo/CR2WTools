
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class EulerAngles
	{
		[REDProp("Pitch")]
		public float Pitch { get; set; }

		[REDProp("Yaw")]
		public float Yaw { get; set; }

		[REDProp("Roll")]
		public float Roll { get; set; }

	}
}
