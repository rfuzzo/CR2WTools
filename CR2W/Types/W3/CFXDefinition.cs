
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CFXDefinition : CObject
	{
		[W3Type("trackGroups")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CFXTrackGroup>> TrackGroups { get; set; }

		[W3Type("length")]
		public float Length { get; set; }

		[W3Type("loopStart")]
		public float LoopStart { get; set; }

		[W3Type("loopEnd")]
		public float LoopEnd { get; set; }

		[W3Type("name")]
		public CName Name { get; set; }

		[W3Type("animationName")]
		public CName AnimationName { get; set; }

		[W3Type("showDistance")]
		public float ShowDistance { get; set; }

		[W3Type("stayInMemory")]
		public bool StayInMemory { get; set; }

		[W3Type("isLooped")]
		public bool IsLooped { get; set; }

		[W3Type("randomStart")]
		public bool RandomStart { get; set; }

	}
}
