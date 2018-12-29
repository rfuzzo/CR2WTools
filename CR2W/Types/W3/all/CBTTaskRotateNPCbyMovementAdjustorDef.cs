using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRotateNPCbyMovementAdjustorDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("target")]
public Handle<CActor> Target { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("finishTaskOnAllowBlend")]
public bool FinishTaskOnAllowBlend { get; set;}

#endregion
}
}