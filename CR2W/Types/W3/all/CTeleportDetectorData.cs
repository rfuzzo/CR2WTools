using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTeleportDetectorData : CObject
{
#region RED Properties

[REDProp("angleDif")]
public float AngleDif { get; set;}

[REDProp("pelvisPositionThreshold")]
public float PelvisPositionThreshold { get; set;}

[REDProp("pelvisTeleportData")]
public STeleportBone PelvisTeleportData { get; set;}

[REDProp("teleportedBones")]
public Array<STeleportBone> TeleportedBones { get; set;}

#endregion
}
}