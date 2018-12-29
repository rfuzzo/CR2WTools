using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CQuestLogicOperationCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("logicOperation")]
public ELogicOperation LogicOperation { get; set;}

[REDProp("conditions")]
public Array<Ptr<IQuestCondition>> Conditions { get; set;}

#endregion
}
}