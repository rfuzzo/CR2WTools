using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerInput : CObject
{
#region RED Properties

[REDProp("actionLocks")]
public Array<Array<SInputActionLock>> ActionLocks { get; set;}

[REDProp("totalCameraPresetChange")]
public float TotalCameraPresetChange { get; set;}

[REDProp("potAction")]
public SInputAction PotAction { get; set;}

[REDProp("potPress")]
public bool PotPress { get; set;}

[REDProp("debugBlockSourceName")]
public CName DebugBlockSourceName { get; set;}

[REDProp("holdFastMenuInvoked")]
public bool HoldFastMenuInvoked { get; set;}

[REDProp("potionUpperHeld")]
public bool PotionUpperHeld { get; set;}

[REDProp("potionLowerHeld")]
public bool PotionLowerHeld { get; set;}

[REDProp("potionModeHold")]
public bool PotionModeHold { get; set;}

[REDProp("pressTimestamp")]
public float PressTimestamp { get; set;}

[REDProp("DOUBLE_TAP_WINDOW")]
public float DOUBLE_TAP_WINDOW { get; set;}

[REDProp("processedSwordHold")]
public bool ProcessedSwordHold { get; set;}

[REDProp("lastMovementDoubleTapName")]
public CName LastMovementDoubleTapName { get; set;}

#endregion
}
}