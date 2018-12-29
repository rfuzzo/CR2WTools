using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondCanLandAtPositionDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("localOffset")]
public Vector LocalOffset { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("maxDistanceFromGround")]
public CBehTreeValFloat MaxDistanceFromGround { get; set;}

[REDProp("landOnlyInGuardArea")]
public bool LandOnlyInGuardArea { get; set;}

#endregion
}
}