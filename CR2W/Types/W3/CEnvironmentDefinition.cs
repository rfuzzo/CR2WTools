using System;

namespace CR2W.Types.W3
{
	public class CEnvironmentDefinition : CResource
	{
		[REDProp("envParams")]
		public CAreaEnvironmentParams EnvParams { get; set; }
	}
}
