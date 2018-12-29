using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_CanSeePlayer_Listener : IGlobalEventScriptedListener
{
#region RED Properties

[REDProp("condition")]
public Handle<W3QuestCond_CanSeePlayer> Condition { get; set;}

#endregion
}
}