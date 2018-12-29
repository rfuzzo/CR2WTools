using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ISpawnAddAbilityInitializer : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("remove")]
public bool Remove { get; set;}

[REDProp("abulities")]
public Array<CName> Abulities { get; set;}

[REDProp("abilityName")]
public CName AbilityName { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}