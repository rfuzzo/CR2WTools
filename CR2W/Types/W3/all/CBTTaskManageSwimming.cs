using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageSwimming : IBehTreeTask
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("isSwimmingValue")]
public bool IsSwimmingValue { get; set;}

[REDProp("m_isInWater")]
public bool M_isInWater { get; set;}

[REDProp("m_isWaitingForWater")]
public bool M_isWaitingForWater { get; set;}

#endregion
}
}