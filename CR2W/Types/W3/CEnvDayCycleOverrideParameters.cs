using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvDayCycleOverrideParameters 
{
#region RED Properties

[REDProp("fakeDayCycleEnable")]
public bool FakeDayCycleEnable { get; set;}

[REDProp("fakeDayCycleHour")]
public float FakeDayCycleHour { get; set;}

[REDProp("enableCustomSunRotation")]
public bool EnableCustomSunRotation { get; set;}

[REDProp("customSunRotation")]
public EulerAngles CustomSunRotation { get; set;}

#endregion
}
}