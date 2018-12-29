using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SpringDamper : CObject
{
#region RED Properties

[REDProp("destValue")]
public float DestValue { get; set;}

[REDProp("currValue")]
public float CurrValue { get; set;}

[REDProp("velValue")]
public float VelValue { get; set;}

[REDProp("smoothTime")]
public float SmoothTime { get; set;}

#endregion
}
}