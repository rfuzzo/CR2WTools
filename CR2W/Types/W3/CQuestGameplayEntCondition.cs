using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestGameplayEntCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("checkType")]
public Ptr<IGameplayEntConditionType> CheckType { get; set;}

#endregion
}
}