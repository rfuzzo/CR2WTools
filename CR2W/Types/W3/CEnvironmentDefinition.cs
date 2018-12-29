using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvironmentDefinition : CResource
	{
		[REDProp("envParams")]
		public CAreaEnvironmentParams EnvParams { get; set; }
	}
}
