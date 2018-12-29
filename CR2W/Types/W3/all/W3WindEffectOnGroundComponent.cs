using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WindEffectOnGroundComponent : CSelfUpdatingComponent
{
#region RED Properties

[REDProp("maxDistanceFromGround")]
public float MaxDistanceFromGround { get; set;}

[REDProp("activeAtStart")]
public bool ActiveAtStart { get; set;}

[REDProp("playOnAnimEvent")]
public bool PlayOnAnimEvent { get; set;}

[REDProp("activateOnAnimEvent")]
public bool ActivateOnAnimEvent { get; set;}

[REDProp("animEvent")]
public CName AnimEvent { get; set;}

[REDProp("deactivateAnimEvent")]
public CName DeactivateAnimEvent { get; set;}

[REDProp("delayBetweenEffects")]
public float DelayBetweenEffects { get; set;}

[REDProp("effectTemplate")]
public Handle<CEntityTemplate> EffectTemplate { get; set;}

[REDProp("m_isActive")]
public bool M_isActive { get; set;}

[REDProp("m_effectEntity")]
public Handle<CEntity> M_effectEntity { get; set;}

[REDProp("m_collisionGroupNames")]
public Array<CName> M_collisionGroupNames { get; set;}

[REDProp("m_delayUntilNextEffect")]
public float M_delayUntilNextEffect { get; set;}

#endregion
}
}