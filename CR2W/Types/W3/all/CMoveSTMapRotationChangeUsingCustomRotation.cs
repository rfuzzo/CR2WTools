using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSTMapRotationChangeUsingCustomRotation : IMoveSteeringTask
{
#region RED Properties

[REDProp("defaultMaxDirectionChange")]
public float DefaultMaxDirectionChange { get; set;}

[REDProp("defaultMaxRotationChange")]
public float DefaultMaxRotationChange { get; set;}

#endregion
}
}