using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlaySyncAnim : IBehTreeTask
{
#region RED Properties

[REDProp("useSetupSimpleSyncAnim2")]
public bool UseSetupSimpleSyncAnim2 { get; set;}

[REDProp("syncAnimNameLeftStance")]
public CName SyncAnimNameLeftStance { get; set;}

[REDProp("syncAnimNameRightStance")]
public CName SyncAnimNameRightStance { get; set;}

[REDProp("raiseForceIdle")]
public bool RaiseForceIdle { get; set;}

[REDProp("denyWhenTargetIsDodging")]
public bool DenyWhenTargetIsDodging { get; set;}

[REDProp("denyIfTargetNotPlayer")]
public bool DenyIfTargetNotPlayer { get; set;}

[REDProp("onAnimEvent")]
public CName OnAnimEvent { get; set;}

[REDProp("onGameplayEvent")]
public CName OnGameplayEvent { get; set;}

[REDProp("shouldComplete")]
public bool ShouldComplete { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

#endregion
}
}