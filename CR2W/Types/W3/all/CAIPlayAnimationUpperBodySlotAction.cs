using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIPlayAnimationUpperBodySlotAction : IActionDecorator
{
#region RED Properties

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("interruptScriptedActionOnSlotAnimEnd")]
public bool InterruptScriptedActionOnSlotAnimEnd { get; set;}

#endregion
}
}