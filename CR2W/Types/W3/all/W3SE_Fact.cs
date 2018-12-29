using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_Fact : W3SwitchEvent
{
#region RED Properties

[REDProp("fact")]
public string Fact { get; set;}

[REDProp("operation")]
public EFactOperation Operation { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("validFor")]
public Int32 ValidFor { get; set;}

#endregion
}
}