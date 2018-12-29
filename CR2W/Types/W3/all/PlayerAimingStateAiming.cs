using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PlayerAimingStateAiming : CScriptableState
{
#region RED Properties

[REDProp("SLOWMO_SPEED")]
public float SLOWMO_SPEED { get; set;}

[REDProp("AIM_ENTITY_DISPLACEMENT")]
public float AIM_ENTITY_DISPLACEMENT { get; set;}

[REDProp("aimEntity")]
public Handle<CEntity> AimEntity { get; set;}

[REDProp("radiusEntity")]
public Handle<CEntity> RadiusEntity { get; set;}

[REDProp("stopAiming")]
public bool StopAiming { get; set;}

[REDProp("startTime")]
public float StartTime { get; set;}

[REDProp("traceManager")]
public Handle<CScriptBatchQueryAccessor> TraceManager { get; set;}

[REDProp("cachedCamDirection")]
public Vector CachedCamDirection { get; set;}

[REDProp("cachedCamPosition")]
public Vector CachedCamPosition { get; set;}

[REDProp("cachedOwnerPosition")]
public Vector CachedOwnerPosition { get; set;}

[REDProp("sweepId")]
public SScriptSweepId SweepId { get; set;}

[REDProp("throwPosInitial")]
public Vector ThrowPosInitial { get; set;}

[REDProp("cachedTime")]
public float CachedTime { get; set;}

[REDProp("speedMultCasuserId")]
public Int32 SpeedMultCasuserId { get; set;}

#endregion
}
}