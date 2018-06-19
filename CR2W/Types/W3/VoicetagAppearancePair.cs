
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class VoicetagAppearancePair
	{
		[W3Type("voicetag")]
		public CName Voicetag { get; set; }

		[W3Type("appearance")]
		public CName Appearance { get; set; }

	}
}
