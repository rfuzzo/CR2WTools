using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskAgony : IBehTreeTask
{
#region RED Properties

[REDProp("agonyTime")]
public Int32 AgonyTime { get; set;}

[REDProp("syncInstance")]
public Handle<CAnimationManualSlotSyncInstance> SyncInstance { get; set;}

[REDProp("disableAgony")]
public bool DisableAgony { get; set;}

[REDProp("chance")]
public Int32 Chance { get; set;}

[REDProp("forceAgony")]
public bool ForceAgony { get; set;}

#endregion
}
}