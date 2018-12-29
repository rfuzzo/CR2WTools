using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAIReactionRange 
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("rangeMax")]
public float RangeMax { get; set;}

[REDProp("rangeAngle")]
public float RangeAngle { get; set;}

[REDProp("rangeBottom")]
public float RangeBottom { get; set;}

[REDProp("rangeTop")]
public float RangeTop { get; set;}

[REDProp("yaw")]
public float Yaw { get; set;}

#endregion
}
}