using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTMaintainRandomSpeed : IManageSpeedSteeringTask
{
#region RED Properties

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("minSpeed")]
public float MinSpeed { get; set;}

[REDProp("maxSpeed")]
public float MaxSpeed { get; set;}

#endregion
}
}