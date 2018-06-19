
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SPropertyAnimation
	{
		[W3Type("propertyName")]
		public CName PropertyName { get; set; }

		[W3Type("animationName")]
		public CName AnimationName { get; set; }

		[W3Type("curve")]
		public SMultiCurve Curve { get; set; }

		[W3Type("playOnStartup")]
		public bool PlayOnStartup { get; set; }

		[W3Type("effectToPlay")]
		public CName EffectToPlay { get; set; }

	}
}
