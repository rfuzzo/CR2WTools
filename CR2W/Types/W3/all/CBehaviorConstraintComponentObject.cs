using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorConstraintComponentObject : CBehaviorConstraintBoneObject
{
#region RED Properties

[REDProp("localPositionOffset")]
public Vector LocalPositionOffset { get; set;}

[REDProp("localRotationOffset")]
public EulerAngles LocalRotationOffset { get; set;}

[REDProp("Bone")]
public string Bone { get; set;}

[REDProp("componentName")]
public string ComponentName { get; set;}

#endregion
}
}