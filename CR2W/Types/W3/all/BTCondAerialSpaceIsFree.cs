using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondAerialSpaceIsFree : IBehTreeTask
{
#region RED Properties

[REDProp("localOffset")]
public Vector LocalOffset { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("cylinderRadiusToCheck")]
public float CylinderRadiusToCheck { get; set;}

[REDProp("cylinderHeightToCheck")]
public float CylinderHeightToCheck { get; set;}

[REDProp("checkedNode")]
public ETargetName CheckedNode { get; set;}

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

[REDProp("m_CollisionGroupNames")]
public Array<CName> M_CollisionGroupNames { get; set;}

[REDProp("m_LastTestTime")]
public float M_LastTestTime { get; set;}

[REDProp("m_LastTestResult")]
public bool M_LastTestResult { get; set;}

#endregion
}
}