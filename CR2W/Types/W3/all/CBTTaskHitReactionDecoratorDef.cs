using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHitReactionDecoratorDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("createHitReactionEvent")]
public CBehTreeValCName CreateHitReactionEvent { get; set;}

[REDProp("increaseHitCounterOnlyOnMeleeDmg")]
public CBehTreeValBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

#endregion
}
}