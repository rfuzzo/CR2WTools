using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGameEnvironmentParams 
{
#region RED Properties

[REDProp("radialBlur")]
public CEnvRadialBlurParameters RadialBlur { get; set;}

[REDProp("fullscreenBlurIntensity")]
public float FullscreenBlurIntensity { get; set;}

[REDProp("gameUnderwaterBrightness")]
public float GameUnderwaterBrightness { get; set;}

[REDProp("dayCycleOverride")]
public CEnvDayCycleOverrideParameters DayCycleOverride { get; set;}

[REDProp("brightnessTint")]
public CEnvBrightnessTintParameters BrightnessTint { get; set;}

[REDProp("displaySettings")]
public CEnvDisplaySettingsParams DisplaySettings { get; set;}

[REDProp("cutsceneDofMode")]
public bool CutsceneDofMode { get; set;}

[REDProp("cutsceneOrDialog")]
public bool CutsceneOrDialog { get; set;}

#endregion
}
}