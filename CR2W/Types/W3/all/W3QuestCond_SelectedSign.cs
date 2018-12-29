using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_SelectedSign : CQuestScriptedCondition
{
#region RED Properties

[REDProp("signType")]
public ESignType SignType { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_SelectedSign_Listener> Listener { get; set;}

[REDProp("factsNames")]
public Array<string> FactsNames { get; set;}

#endregion
}
}