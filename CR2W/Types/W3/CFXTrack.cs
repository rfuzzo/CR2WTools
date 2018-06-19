
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CFXTrack : CFXBase
	{
		[W3Type("trackItems")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CFXTrackItem>> TrackItems { get; set; }

		[W3Type("name")]
		public string Name { get; set; }

	}
}
