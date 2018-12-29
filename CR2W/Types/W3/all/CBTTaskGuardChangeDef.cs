using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGuardChangeDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDectivate")]
public bool OnDectivate { get; set;}

[REDProp("onMain")]
public bool OnMain { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

[REDProp("raiseCheck")]
public bool RaiseCheck { get; set;}

[REDProp("lowerCheck")]
public bool LowerCheck { get; set;}

#endregion
}
}