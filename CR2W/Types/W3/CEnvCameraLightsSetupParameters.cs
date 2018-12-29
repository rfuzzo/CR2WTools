
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvCameraLightsSetupParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("gameplayLight0")]
		public CEnvCameraLightParameters GameplayLight0 { get; set; }

		[REDProp("gameplayLight1")]
		public CEnvCameraLightParameters GameplayLight1 { get; set; }

		[REDProp("sceneLight0")]
		public CEnvCameraLightParameters SceneLight0 { get; set; }

		[REDProp("sceneLight1")]
		public CEnvCameraLightParameters SceneLight1 { get; set; }

		[REDProp("dialogLight0")]
		public CEnvCameraLightParameters DialogLight0 { get; set; }

		[REDProp("dialogLight1")]
		public CEnvCameraLightParameters DialogLight1 { get; set; }

		[REDProp("interiorLight0")]
		public CEnvCameraLightParameters InteriorLight0 { get; set; }

		[REDProp("interiorLight1")]
		public CEnvCameraLightParameters InteriorLight1 { get; set; }

		[REDProp("playerInInteriorLightsScale")]
		public SSimpleCurve PlayerInInteriorLightsScale { get; set; }

		[REDProp("sceneLightColorInterior0")]
		public SSimpleCurve SceneLightColorInterior0 { get; set; }

		[REDProp("sceneLightColorInterior1")]
		public SSimpleCurve SceneLightColorInterior1 { get; set; }

		[REDProp("cameraLightsNonCharacterScale")]
		public SSimpleCurve CameraLightsNonCharacterScale { get; set; }

	}
}
