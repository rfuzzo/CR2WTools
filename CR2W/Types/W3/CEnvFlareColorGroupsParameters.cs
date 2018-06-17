
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvFlareColorGroupsParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("default")]
		public CEnvFlareColorParameters Default { get; set; }

		[W3Type("custom0")]
		public CEnvFlareColorParameters Custom0 { get; set; }

		[W3Type("custom1")]
		public CEnvFlareColorParameters Custom1 { get; set; }

		[W3Type("custom2")]
		public CEnvFlareColorParameters Custom2 { get; set; }

	}
}
