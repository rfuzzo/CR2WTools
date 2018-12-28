using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SWanderAndWorkEntryGeneratorParams 
{
#region RED Properties

[REDProp("creatureEntry")]
public SCreatureEntryEntryGeneratorNodeParam CreatureEntry { get; set;}

[REDProp("wander")]
public SWanderHistoryEntryGeneratorParams Wander { get; set;}

[REDProp("work")]
public SWorkWanderSmartAIEntryGeneratorParam Work { get; set;}

#endregion
}
}