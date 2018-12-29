using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Switch : CGameplayEntity
{
#region RED Properties

[REDProp("isInitiallyEnabled")]
public bool IsInitiallyEnabled { get; set;}

[REDProp("isInitiallyLocked")]
public bool IsInitiallyLocked { get; set;}

[REDProp("isInitiallyOn")]
public bool IsInitiallyOn { get; set;}

[REDProp("maxUseCount")]
public Int32 MaxUseCount { get; set;}

[REDProp("skipEventsAtBeginning")]
public bool SkipEventsAtBeginning { get; set;}

[REDProp("whenOnEvents")]
public Array<Handle<W3SwitchEvent>> WhenOnEvents { get; set;}

[REDProp("whenOffEvents")]
public Array<Handle<W3SwitchEvent>> WhenOffEvents { get; set;}

[REDProp("whenSwitchedEvents")]
public Array<Handle<W3SwitchEvent>> WhenSwitchedEvents { get; set;}

[REDProp("currentState")]
public ESwitchState CurrentState { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("locked")]
public bool Locked { get; set;}

[REDProp("totalUseCount")]
public Int32 TotalUseCount { get; set;}

[REDProp("skipEvents")]
public bool SkipEvents { get; set;}

[REDProp("virtualSwitchesLinkedHandle")]
public Array<EntityHandle> VirtualSwitchesLinkedHandle { get; set;}

[REDProp("lastActivatorHandle")]
public EntityHandle LastActivatorHandle { get; set;}

[REDProp("restoreUsableItemL")]
public bool RestoreUsableItemL { get; set;}

[REDProp("BEH_ON")]
public float BEH_ON { get; set;}

[REDProp("BEH_OFF")]
public float BEH_OFF { get; set;}

[REDProp("BEH_ON_FROM_OFF")]
public float BEH_ON_FROM_OFF { get; set;}

[REDProp("BEH_OFF_FROM_ON")]
public float BEH_OFF_FROM_ON { get; set;}

#endregion
}
}