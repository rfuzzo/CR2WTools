using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAISenseParams : CObject
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("rangeMin")]
public float RangeMin { get; set;}

[REDProp("rangeMax")]
public float RangeMax { get; set;}

[REDProp("rangeAngle")]
public float RangeAngle { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("testLOS")]
public bool TestLOS { get; set;}

[REDProp("detectOnlyHostiles")]
public bool DetectOnlyHostiles { get; set;}

#endregion
}
}