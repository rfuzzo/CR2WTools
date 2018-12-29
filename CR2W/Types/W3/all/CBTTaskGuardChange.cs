using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGuardChange : IBehTreeTask
{
#region RED Properties

[REDProp("raiseGuardChance")]
public Int32 RaiseGuardChance { get; set;}

[REDProp("lowerGuardChance")]
public Int32 LowerGuardChance { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDectivate")]
public bool OnDectivate { get; set;}

[REDProp("onMain")]
public bool OnMain { get; set;}

[REDProp("raiseCheck")]
public bool RaiseCheck { get; set;}

[REDProp("lowerCheck")]
public bool LowerCheck { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

[REDProp("lastChange")]
public float LastChange { get; set;}

#endregion
}
}