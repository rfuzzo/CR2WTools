using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTSetupRotationChange : IMoveSteeringTask
{
#region RED Properties

[REDProp("maxDirectionChange")]
public float MaxDirectionChange { get; set;}

[REDProp("maxRotationChange")]
public float MaxRotationChange { get; set;}

#endregion
}
}