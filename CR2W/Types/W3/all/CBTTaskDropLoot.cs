using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDropLoot : IBehTreeTask
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("lootDropped")]
public bool LootDropped { get; set;}

[REDProp("attacker")]
public Handle<CGameplayEntity> Attacker { get; set;}

[REDProp("causer")]
public Handle<IScriptable> Causer { get; set;}

[REDProp("saveLockID")]
public Int32 SaveLockID { get; set;}

#endregion
}
}