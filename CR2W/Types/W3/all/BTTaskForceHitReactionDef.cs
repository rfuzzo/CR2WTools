using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskForceHitReactionDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("hitReactionType")]
public Handle<CBTEnumHitReactionType> HitReactionType { get; set;}

[REDProp("hitReactionSide")]
public Handle<CBTEnumHitReactionSide> HitReactionSide { get; set;}

[REDProp("hitReactionDirection")]
public Handle<CBTEnumHitReactionDirection> HitReactionDirection { get; set;}

[REDProp("hitSwingType")]
public Handle<CBTEnumAttackSwingType> HitSwingType { get; set;}

[REDProp("hitSwingDirection")]
public Handle<CBTEnumAttackSwingDriection> HitSwingDirection { get; set;}

#endregion
}
}