using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphPointCloudLookAtSecMotion : CObject
{
#region RED Properties

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("masterBones")]
public Array<Int32> MasterBones { get; set;}

[REDProp("masterBoneAxis")]
public EAxis MasterBoneAxis { get; set;}

[REDProp("maxMasterMotionAngleDeg")]
public float MaxMasterMotionAngleDeg { get; set;}

[REDProp("defaultAnimation")]
public CName DefaultAnimation { get; set;}

#endregion
}
}