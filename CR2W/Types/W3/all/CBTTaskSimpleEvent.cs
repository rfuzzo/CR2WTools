using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSimpleEvent : IBehTreeTask
{
#region RED Properties

[REDProp("available")]
public bool Available { get; set;}

[REDProp("Delay")]
public float Delay { get; set;}

[REDProp("Event")]
public CName Event { get; set;}

#endregion
}
}