using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskMaintainDistanceDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("faceTarget")]
public bool FaceTarget { get; set;}

[REDProp("fromOutsideDuration")]
public float FromOutsideDuration { get; set;}

[REDProp("forceTarget")]
public CName ForceTarget { get; set;}

#endregion
}
}