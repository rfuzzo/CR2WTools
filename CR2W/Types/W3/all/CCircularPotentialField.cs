using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCircularPotentialField : IPotentialField
{
#region RED Properties

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("rangeTop")]
public float RangeTop { get; set;}

[REDProp("rangeBottom")]
public float RangeBottom { get; set;}

[REDProp("origin")]
public Vector Origin { get; set;}

[REDProp("solid")]
public bool Solid { get; set;}

#endregion
}
}