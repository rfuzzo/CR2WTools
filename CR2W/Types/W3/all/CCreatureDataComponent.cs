using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCreatureDataComponent : CScriptedComponent
{
#region RED Properties

[REDProp("itemsUsedAgainstCreature")]
public Array<CName> ItemsUsedAgainstCreature { get; set;}

[REDProp("skillsUsedAgainstCreature")]
public Array<CName> SkillsUsedAgainstCreature { get; set;}

[REDProp("cameraDistance")]
public float CameraDistance { get; set;}

[REDProp("cameraLookAtZ")]
public float CameraLookAtZ { get; set;}

[REDProp("cameraRotationYaw")]
public float CameraRotationYaw { get; set;}

[REDProp("cameraRotationPitch")]
public float CameraRotationPitch { get; set;}

[REDProp("environmentSunRotationYaw")]
public float EnvironmentSunRotationYaw { get; set;}

[REDProp("environmentSunRotationPitch")]
public float EnvironmentSunRotationPitch { get; set;}

[REDProp("appearance")]
public CName Appearance { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("fov")]
public float Fov { get; set;}

#endregion
}
}