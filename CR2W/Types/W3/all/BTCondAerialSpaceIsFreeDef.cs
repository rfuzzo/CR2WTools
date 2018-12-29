using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondAerialSpaceIsFreeDef : IBehTreeConditionalTaskDefinition
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

#endregion
}
}