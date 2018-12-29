using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3YrdenEntity : W3SignEntity
{
#region RED Properties

[REDProp("effects")]
public Array<SYrdenEffects> Effects { get; set;}

[REDProp("projTemplate")]
public Handle<CEntityTemplate> ProjTemplate { get; set;}

[REDProp("projDestroyFxEntTemplate")]
public Handle<CEntityTemplate> ProjDestroyFxEntTemplate { get; set;}

[REDProp("runeTemplates")]
public Array<Handle<CEntityTemplate>> RuneTemplates { get; set;}

[REDProp("validTargetsInArea")]
public Array<Handle<CActor>> ValidTargetsInArea { get; set;}

[REDProp("allActorsInArea")]
public Array<Handle<CActor>> AllActorsInArea { get; set;}

[REDProp("flyersInArea")]
public Array<Handle<CNewNPC>> FlyersInArea { get; set;}

[REDProp("trapDuration")]
public float TrapDuration { get; set;}

[REDProp("charges")]
public Int32 Charges { get; set;}

[REDProp("isPlayerInside")]
public bool IsPlayerInside { get; set;}

[REDProp("baseModeRange")]
public float BaseModeRange { get; set;}

[REDProp("notFromPlayerCast")]
public bool NotFromPlayerCast { get; set;}

[REDProp("fxEntities")]
public Array<Handle<CEntity>> FxEntities { get; set;}

#endregion
}
}