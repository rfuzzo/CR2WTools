using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphComboStartingAnimationModifier : IBehaviorGraphComboModifier
{
#region RED Properties

[REDProp("animationAttack")]
public CName AnimationAttack { get; set;}

[REDProp("animationParry")]
public CName AnimationParry { get; set;}

#endregion
}
}