using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionToGiantWeaponMonitor : IBehTreeTask
{
#region RED Properties

[REDProp("effectResourceName")]
public CName EffectResourceName { get; set;}

[REDProp("playFxOnEffectEntity")]
public CName PlayFxOnEffectEntity { get; set;}

[REDProp("spawnZOffset")]
public float SpawnZOffset { get; set;}

[REDProp("effectEntity")]
public Handle<CEntityTemplate> EffectEntity { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("victimsArray")]
public Array<Handle<CActor>> VictimsArray { get; set;}

[REDProp("actorEventReceived")]
public bool ActorEventReceived { get; set;}

[REDProp("entityPos")]
public Vector EntityPos { get; set;}

[REDProp("entityRot")]
public EulerAngles EntityRot { get; set;}

#endregion
}
}