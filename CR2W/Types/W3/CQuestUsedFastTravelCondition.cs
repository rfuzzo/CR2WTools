using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestUsedFastTravelCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("pinTag")]
public CName PinTag { get; set;}

[REDProp("conditionType")]
public EFastTravelConditionType ConditionType { get; set;}

#endregion
}
}