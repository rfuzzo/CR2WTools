
using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct EulerAngles
    {
		[REDProp("Pitch")]
		public float Pitch { get; set; }

		[REDProp("Yaw")]
		public float Yaw { get; set; }

		[REDProp("Roll")]
		public float Roll { get; set; }

	}
}
