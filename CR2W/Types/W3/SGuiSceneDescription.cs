
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SGuiSceneDescription
	{
		[W3Type("enabled")]
		public bool Enabled { get; set; }

		[W3Type("worldClass")]
		public CName WorldClass { get; set; }

		[W3Type("defaultEnvDef")]
		public Soft<CEnvironmentDefinition> DefaultEnvDef { get; set; }

		[W3Type("defaultSunRotation")]
		public EulerAngles DefaultSunRotation { get; set; }

		[W3Type("enablePhysics")]
		public bool EnablePhysics { get; set; }

	}
}
