using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WhiteFrost : W3Petard
{
#region RED Properties

[REDProp("waveProjectileTemplate")]
public Handle<CEntityTemplate> WaveProjectileTemplate { get; set;}

[REDProp("freezeNPCFadeInTime")]
public float FreezeNPCFadeInTime { get; set;}

[REDProp("waveSpeedModifier")]
public float WaveSpeedModifier { get; set;}

[REDProp("HAX_waveRadius")]
public float HAX_waveRadius { get; set;}

[REDProp("collisionMask")]
public Array<CName> CollisionMask { get; set;}

[REDProp("shaderSpeed")]
public float ShaderSpeed { get; set;}

[REDProp("totalTime")]
public float TotalTime { get; set;}

[REDProp("collidedEntities")]
public Array<Handle<CGameplayEntity>> CollidedEntities { get; set;}

[REDProp("waveProjectile")]
public Handle<W3WhiteFrostWaveProjectile> WaveProjectile { get; set;}

#endregion
}
}