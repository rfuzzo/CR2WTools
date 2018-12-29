using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeInitializerSetImmortality : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("immortalityMode")]
public EActorImmortalityMode ImmortalityMode { get; set;}

[REDProp("previousImmortalityMode")]
public EActorImmortalityMode PreviousImmortalityMode { get; set;}

#endregion
}
}