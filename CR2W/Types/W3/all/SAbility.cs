using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAbility 
{
#region RED Properties

[REDProp("attributes")]
public Array<SAbilityAttribute> Attributes { get; set;}

[REDProp("prerequisites")]
public Array<CName> Prerequisites { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("abilities")]
public Array<CName> Abilities { get; set;}

[REDProp("type")]
public int Type { get; set;}

#endregion
}
}