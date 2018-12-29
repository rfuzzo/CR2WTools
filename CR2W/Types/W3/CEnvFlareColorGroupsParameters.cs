
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvFlareColorGroupsParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("default")]
		public CEnvFlareColorParameters Default { get; set; }

		[REDProp("custom0")]
		public CEnvFlareColorParameters Custom0 { get; set; }

		[REDProp("custom1")]
		public CEnvFlareColorParameters Custom1 { get; set; }

		[REDProp("custom2")]
		public CEnvFlareColorParameters Custom2 { get; set; }

	}
}
