using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CEncounterParameters : IAISpawnTreeParameters
{
#region RED Properties

[REDProp("encounter")]
public Handle<CEncounter> Encounter { get; set;}

[REDProp("globalDefaults")]
public Array<Handle<IAISpawnTreeSubParameters>> GlobalDefaults { get; set;}

#endregion
}
}