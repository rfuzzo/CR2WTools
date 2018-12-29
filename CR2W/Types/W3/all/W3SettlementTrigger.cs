using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SettlementTrigger : CR4JournalPlaceEntity
{
#region RED Properties

[REDProp("bDisplaySettlementInfo")]
public bool BDisplaySettlementInfo { get; set;}

[REDProp("settlementName")]
public CName SettlementName { get; set;}

[REDProp("hubNameOverride")]
public CName HubNameOverride { get; set;}

[REDProp("lockReenterDisplayTime")]
public float LockReenterDisplayTime { get; set;}

[REDProp("blockHorseTopSpeed")]
public bool BlockHorseTopSpeed { get; set;}

#endregion
}
}