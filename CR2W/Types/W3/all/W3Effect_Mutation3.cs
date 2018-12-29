using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Mutation3 : CBaseGameplayEffect
{
#region RED Properties

[REDProp("stacks")]
public Int32 Stacks { get; set;}

[REDProp("maxCap")]
public Int32 MaxCap { get; set;}

[REDProp("apBonus")]
public float ApBonus { get; set;}

#endregion
}
}