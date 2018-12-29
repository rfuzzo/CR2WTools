using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SyncAnimationManager : CObject
{
#region RED Properties

[REDProp("syncInstances")]
public Array<Handle<CAnimationManualSlotSyncInstance>> SyncInstances { get; set;}

[REDProp("masterEntity")]
public Handle<CGameplayEntity> MasterEntity { get; set;}

[REDProp("slaveEntity")]
public Handle<CGameplayEntity> SlaveEntity { get; set;}

[REDProp("syncActionName")]
public CName SyncActionName { get; set;}

[REDProp("dlcFinishersLeftSide")]
public Array<Handle<CR4FinisherDLC>> DlcFinishersLeftSide { get; set;}

[REDProp("dlcFinishersRightSide")]
public Array<Handle<CR4FinisherDLC>> DlcFinishersRightSide { get; set;}

[REDProp("cameraAnimName")]
public CName CameraAnimName { get; set;}

#endregion
}
}