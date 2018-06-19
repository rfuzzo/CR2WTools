
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CFXTrackGroup : CFXBase
	{
		[W3Type("name")]
		public string Name { get; set; }

		[W3Type("tracks")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CFXTrack>> Tracks { get; set; }

		[W3Type("isExpanded")]
		public bool IsExpanded { get; set; }

		[W3Type("isEnabled")]
		public bool IsEnabled { get; set; }

		[W3Type("trackGroupColor")]
		public Color TrackGroupColor { get; set; }

		[W3Type("componentName")]
		public CName ComponentName { get; set; }

	}
}
