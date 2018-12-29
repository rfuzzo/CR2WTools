using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIInterruptableByHitAction : IActionDecorator
{
#region RED Properties

[REDProp("shouldForceHitReaction")]
public bool ShouldForceHitReaction { get; set;}

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("hitReactionSide")]
public EHitReactionSide HitReactionSide { get; set;}

[REDProp("hitReactionDirection")]
public EHitReactionDirection HitReactionDirection { get; set;}

[REDProp("hitSwingType")]
public EAttackSwingType HitSwingType { get; set;}

[REDProp("hitSwingDirection")]
public EAttackSwingDirection HitSwingDirection { get; set;}

#endregion
}
}