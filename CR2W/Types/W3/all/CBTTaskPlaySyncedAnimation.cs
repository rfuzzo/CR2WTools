using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlaySyncedAnimation : IBehTreeTask
{
#region RED Properties

[REDProp("isRunning")]
public bool IsRunning { get; set;}

[REDProp("shouldStartAnimation")]
public bool ShouldStartAnimation { get; set;}

[REDProp("syncInstance")]
public Handle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

[REDProp("sequenceIndex")]
public Int32 SequenceIndex { get; set;}

[REDProp("forceEventOnEnd")]
public CName ForceEventOnEnd { get; set;}

[REDProp("gameplayEventOnEnd")]
public CName GameplayEventOnEnd { get; set;}

[REDProp("finisherSyncAnim")]
public bool FinisherSyncAnim { get; set;}

[REDProp("completeSuccess")]
public bool CompleteSuccess { get; set;}

#endregion
}
}