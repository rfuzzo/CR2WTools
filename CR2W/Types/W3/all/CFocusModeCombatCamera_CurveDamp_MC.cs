using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFocusModeCombatCamera_CurveDamp_MC : CObject
{
#region RED Properties

[REDProp("distanceCurveName")]
public CName DistanceCurveName { get; set;}

[REDProp("yawCurveName")]
public CName YawCurveName { get; set;}

[REDProp("pitchCurveName")]
public CName PitchCurveName { get; set;}

[REDProp("fovCurveName")]
public CName FovCurveName { get; set;}

[REDProp("desiredPitch")]
public float DesiredPitch { get; set;}

[REDProp("autoTimeUpdate")]
public bool AutoTimeUpdate { get; set;}

[REDProp("distanceDamper")]
public Handle<CurveDamper> DistanceDamper { get; set;}

[REDProp("yawDamper")]
public Handle<AngleCurveDamper> YawDamper { get; set;}

[REDProp("pitchDamper")]
public Handle<AngleCurveDamper> PitchDamper { get; set;}

[REDProp("fovDamper")]
public Handle<CurveDamper> FovDamper { get; set;}

[REDProp("distanceStart")]
public float DistanceStart { get; set;}

[REDProp("pitchStart")]
public float PitchStart { get; set;}

[REDProp("yawStart")]
public float YawStart { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("rotation")]
public EulerAngles Rotation { get; set;}

[REDProp("timeScale")]
public float TimeScale { get; set;}

#endregion
}
}