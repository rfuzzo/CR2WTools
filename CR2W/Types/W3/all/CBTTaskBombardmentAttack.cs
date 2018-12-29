using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBombardmentAttack : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("performBombardment")]
public bool PerformBombardment { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("resourceName")]
public string ResourceName { get; set;}

[REDProp("afterSpawnDelay")]
public float AfterSpawnDelay { get; set;}

[REDProp("initialDelay")]
public float InitialDelay { get; set;}

[REDProp("yOffset")]
public float YOffset { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

#endregion
}
}