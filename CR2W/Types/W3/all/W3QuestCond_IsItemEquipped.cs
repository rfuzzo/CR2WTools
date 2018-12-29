using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsItemEquipped : CQuestScriptedCondition
{
#region RED Properties

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("categoryName")]
public CName CategoryName { get; set;}

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_IsItemEquipped_Listener> Listener { get; set;}

#endregion
}
}