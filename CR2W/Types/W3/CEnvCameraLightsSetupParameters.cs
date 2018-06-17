
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvCameraLightsSetupParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("gameplayLight0")]
		public CEnvCameraLightParameters GameplayLight0 { get; set; }

		[W3Type("gameplayLight1")]
		public CEnvCameraLightParameters GameplayLight1 { get; set; }

		[W3Type("sceneLight0")]
		public CEnvCameraLightParameters SceneLight0 { get; set; }

		[W3Type("sceneLight1")]
		public CEnvCameraLightParameters SceneLight1 { get; set; }

		[W3Type("dialogLight0")]
		public CEnvCameraLightParameters DialogLight0 { get; set; }

		[W3Type("dialogLight1")]
		public CEnvCameraLightParameters DialogLight1 { get; set; }

		[W3Type("interiorLight0")]
		public CEnvCameraLightParameters InteriorLight0 { get; set; }

		[W3Type("interiorLight1")]
		public CEnvCameraLightParameters InteriorLight1 { get; set; }

		[W3Type("playerInInteriorLightsScale")]
		public SSimpleCurve PlayerInInteriorLightsScale { get; set; }

		[W3Type("sceneLightColorInterior0")]
		public SSimpleCurve SceneLightColorInterior0 { get; set; }

		[W3Type("sceneLightColorInterior1")]
		public SSimpleCurve SceneLightColorInterior1 { get; set; }

		[W3Type("cameraLightsNonCharacterScale")]
		public SSimpleCurve CameraLightsNonCharacterScale { get; set; }

	}
}
