using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageBlindCreature : IBehTreeTask
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("forgetTargetIfNPCSpeedLowerThan")]
public float ForgetTargetIfNPCSpeedLowerThan { get; set;}

[REDProp("remberTargetIfCloserThan")]
public float RemberTargetIfCloserThan { get; set;}

[REDProp("ignoreNoiseLowerThanWhenSprinting")]
public float IgnoreNoiseLowerThanWhenSprinting { get; set;}

[REDProp("prioritizePlayerAsTarget")]
public bool PrioritizePlayerAsTarget { get; set;}

[REDProp("teleportEntity")]
public bool TeleportEntity { get; set;}

[REDProp("checkedForActors")]
public bool CheckedForActors { get; set;}

[REDProp("echoPingShot")]
public bool EchoPingShot { get; set;}

[REDProp("echoTimeStamp")]
public float EchoTimeStamp { get; set;}

[REDProp("delayEchoDetectionFX")]
public float DelayEchoDetectionFX { get; set;}

[REDProp("noiseSourceEntities")]
public Array<SNoiseEntity> NoiseSourceEntities { get; set;}

[REDProp("actors")]
public Array<Handle<CActor>> Actors { get; set;}

[REDProp("noiseSourceEntity")]
public SNoiseEntity NoiseSourceEntity { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("PING_SPEED")]
public float PING_SPEED { get; set;}

[REDProp("PING_NOISE_LEVEL")]
public float PING_NOISE_LEVEL { get; set;}

[REDProp("BOMB_NOISE_LEVEL")]
public float BOMB_NOISE_LEVEL { get; set;}

[REDProp("SIGN_NOISE_LEVEL")]
public float SIGN_NOISE_LEVEL { get; set;}

[REDProp("BATTLECRY_NOISE_LEVEL")]
public float BATTLECRY_NOISE_LEVEL { get; set;}

[REDProp("ATTACK_NOISE_LEVEL")]
public float ATTACK_NOISE_LEVEL { get; set;}

[REDProp("MOVE_NOISE_LEVEL")]
public float MOVE_NOISE_LEVEL { get; set;}

[REDProp("Z_TOLERANCE")]
public float Z_TOLERANCE { get; set;}

[REDProp("NAVIGATION_SEARCH_RADIUS")]
public float NAVIGATION_SEARCH_RADIUS { get; set;}

[REDProp("NAVIGATION_SEARCH_TIMEOUT")]
public float NAVIGATION_SEARCH_TIMEOUT { get; set;}

#endregion
}
}