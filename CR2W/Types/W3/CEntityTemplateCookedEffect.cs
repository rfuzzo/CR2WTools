
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntityTemplateCookedEffect
	{
		[W3Type("name")]
		public CName Name { get; set; }

		[W3Type("animName")]
		public CName AnimName { get; set; }

		[W3Type("buffer")]
		public SharedDataBuffer Buffer { get; set; }

	}
}
