using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEncounterGlobalSettings : CObject
{
#region RED Properties

[REDProp("defaultSpawnStrategy")]
public Ptr<ISpawnTreeSpawnStrategy> DefaultSpawnStrategy { get; set;}

[REDProp("groupLimits")]
public Array<SEncounterGroupLimit> GroupLimits { get; set;}

#endregion
}
}