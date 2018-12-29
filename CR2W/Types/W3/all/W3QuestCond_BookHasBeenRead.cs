using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_BookHasBeenRead : CQuestScriptedCondition
{
#region RED Properties

[REDProp("bookName")]
public CName BookName { get; set;}

[REDProp("bookFactName")]
public string BookFactName { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_BookHasBeenRead_Listener> Listener { get; set;}

#endregion
}
}