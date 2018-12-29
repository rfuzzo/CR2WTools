using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_WasNoticeboardVisited : CQuestScriptedCondition
{
#region RED Properties

[REDProp("entityName")]
public CName EntityName { get; set;}

#endregion
}
}