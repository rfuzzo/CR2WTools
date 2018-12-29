using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeHLTaskUnconscious : IBehTreeTask
{
#region RED Properties

[REDProp("syncInstance")]
public Handle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

[REDProp("finisherEnabled")]
public bool FinisherEnabled { get; set;}

#endregion
}
}