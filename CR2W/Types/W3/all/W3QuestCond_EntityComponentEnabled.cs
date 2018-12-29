using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_EntityComponentEnabled : CQuestScriptedCondition
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("componentName")]
public CName ComponentName { get; set;}

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("component")]
public Handle<CComponent> Component { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_EntityComponentEnabled_Listener> Listener { get; set;}

#endregion
}
}