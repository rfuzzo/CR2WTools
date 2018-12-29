using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Potion_Fact : CBaseGameplayEffect
{
#region RED Properties

[REDProp("fact")]
public CName Fact { get; set;}

#endregion
}
}