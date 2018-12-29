using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyAroundTarget : CBTTaskVolumetricMove
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("frontalHeadingOffset")]
public Int32 FrontalHeadingOffset { get; set;}

[REDProp("randomFactor")]
public Int32 RandomFactor { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("randomHeightAmplitude")]
public float RandomHeightAmplitude { get; set;}

[REDProp("collisionGroupsNames")]
public Array<CName> CollisionGroupsNames { get; set;}

#endregion
}
}