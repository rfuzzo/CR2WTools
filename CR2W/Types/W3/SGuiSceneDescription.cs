
using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct SGuiSceneDescription
    {
		[REDProp("enabled")]
		public bool Enabled { get; set; }

		[REDProp("worldClass")]
		public CName WorldClass { get; set; }

		[REDProp("defaultEnvDef")]
		public Soft<CEnvironmentDefinition> DefaultEnvDef { get; set; }

		[REDProp("defaultSunRotation")]
		public EulerAngles DefaultSunRotation { get; set; }

		[REDProp("enablePhysics")]
		public bool EnablePhysics { get; set; }

	}
}
