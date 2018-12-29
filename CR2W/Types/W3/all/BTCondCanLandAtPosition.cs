using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondCanLandAtPosition : IBehTreeTask
{
#region RED Properties

[REDProp("localOffset")]
public Vector LocalOffset { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("maxDistanceFromGround")]
public float MaxDistanceFromGround { get; set;}

[REDProp("landOnlyInGuardArea")]
public bool LandOnlyInGuardArea { get; set;}

[REDProp("m_CollisionGroupNames")]
public Array<CName> M_CollisionGroupNames { get; set;}

[REDProp("m_ObstaclesGroupNames")]
public Array<CName> M_ObstaclesGroupNames { get; set;}

#endregion
}
}