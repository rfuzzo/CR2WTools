
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvironmentDefinition : CResource
	{
		[W3Type("envParams")]
		public CAreaEnvironmentParams EnvParams { get; set; }

	}
}
