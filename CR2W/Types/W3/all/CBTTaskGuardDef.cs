using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGuardDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("guardArea_var")]
public CName GuardArea_var { get; set;}

[REDProp("guardPursuitArea_var")]
public CName GuardPursuitArea_var { get; set;}

[REDProp("guardPursuitRange")]
public CBehTreeValFloat GuardPursuitRange { get; set;}

[REDProp("guardRetreatType")]
public Handle<CBTEnumMoveType> GuardRetreatType { get; set;}

[REDProp("guardRetreatSpeed")]
public CBehTreeValFloat GuardRetreatSpeed { get; set;}

[REDProp("guardIntruderTestFrequency")]
public CBehTreeValFloat GuardIntruderTestFrequency { get; set;}

#endregion
}
}