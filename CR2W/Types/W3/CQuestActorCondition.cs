using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestActorCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("actorTag")]
public CName ActorTag { get; set;}

[REDProp("checkType")]
public Ptr<IActorConditionType> CheckType { get; set;}

#endregion
}
}