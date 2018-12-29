using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskIceGiantFallingIciclesDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("rangeForIcyclesActivation")]
public float RangeForIcyclesActivation { get; set;}

#endregion
}
}