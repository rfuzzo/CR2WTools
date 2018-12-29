using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorGraphMapToDiscreteMapper 
{
#region RED Properties

/*[REDProp("Min input value")]
public float Min input value { get; set;}

[REDProp("Max input value")]
public float Max input value { get; set;}*/

[REDProp("outValue")]
public float OutValue { get; set;}

#endregion
}
}