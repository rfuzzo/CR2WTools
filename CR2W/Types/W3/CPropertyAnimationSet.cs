
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CPropertyAnimationSet : CObject
	{
		[W3Type("animations")]
        [W3ArrayFlags(2, 0)]
        public Array<SPropertyAnimation> Animations { get; set; }

	}
}
