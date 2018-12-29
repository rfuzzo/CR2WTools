using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBlockedAbility 
{
#region RED Properties

[REDProp("abilityName")]
public CName AbilityName { get; set;}

[REDProp("timeWhenEnabledd")]
public float TimeWhenEnabledd { get; set;}

[REDProp("count")]
public int Count { get; set;}

#endregion
}
}