using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicMeleeAttack : CBTTaskMagicAttack
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("fxOnAnimEvent")]
public Array<SFxOnAnimEvent> FxOnAnimEvent { get; set;}

[REDProp("effectEntityTemplate")]
public Handle<CEntityTemplate> EffectEntityTemplate { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("dealDmgOnDeactivate")]
public bool DealDmgOnDeactivate { get; set;}

[REDProp("couldntLoadResource")]
public bool CouldntLoadResource { get; set;}

[REDProp("effectHitName")]
public CName EffectHitName { get; set;}

[REDProp("foundPos")]
public bool FoundPos { get; set;}

[REDProp("pos")]
public Vector Pos { get; set;}

[REDProp("rot")]
public EulerAngles Rot { get; set;}

#endregion
}
}