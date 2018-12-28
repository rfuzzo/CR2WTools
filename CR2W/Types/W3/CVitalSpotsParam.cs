using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CVitalSpotsParam : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("journalCreaturVitalSpotsPath")]
public Handle<CJournalPath> JournalCreaturVitalSpotsPath { get; set;}

[REDProp("vitalSpots")]
public Array<Ptr<CVitalSpot>> VitalSpots { get; set;}

#endregion
}
}