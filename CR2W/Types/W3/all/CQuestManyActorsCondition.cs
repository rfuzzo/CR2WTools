using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQuestManyActorsCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("actorTags")]
public TagList ActorTags { get; set;}

[REDProp("logicOperation")]
public EQuestActorConditionLogicOperation LogicOperation { get; set;}

[REDProp("condition")]
public Ptr<IActorConditionType> Condition { get; set;}

#endregion
}
}