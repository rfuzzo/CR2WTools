using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterIdleDecoratorParams : CAIIdleParameters
{
#region RED Properties

[REDProp("reactionTree")]
public Handle<CAIMonsterReactionsTree> ReactionTree { get; set;}

[REDProp("searchFoodTree")]
public Handle<CAIMonsterSearchFoodTree> SearchFoodTree { get; set;}

[REDProp("actions")]
public Array<Handle<CAIMonsterIdleAction>> Actions { get; set;}

[REDProp("nightActions")]
public Array<Handle<CAIMonsterIdleAction>> NightActions { get; set;}

[REDProp("actionCooldown")]
public float ActionCooldown { get; set;}

[REDProp("chanceToHuntAtNight")]
public float ChanceToHuntAtNight { get; set;}

#endregion
}
}