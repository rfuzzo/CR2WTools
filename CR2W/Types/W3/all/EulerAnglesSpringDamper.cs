using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EulerAnglesSpringDamper : CObject
{
#region RED Properties

[REDProp("destValue")]
public EulerAngles DestValue { get; set;}

[REDProp("currValue")]
public EulerAngles CurrValue { get; set;}

[REDProp("velValue")]
public EulerAngles VelValue { get; set;}

[REDProp("smoothTime")]
public float SmoothTime { get; set;}

#endregion
}
}