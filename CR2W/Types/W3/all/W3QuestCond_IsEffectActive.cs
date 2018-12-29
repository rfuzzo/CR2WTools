using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsEffectActive : CQuestScriptedCondition
{
#region RED Properties

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_IsEffectActive_Listener> Listener { get; set;}

#endregion
}
}