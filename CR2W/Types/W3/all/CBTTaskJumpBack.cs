using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskJumpBack : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("chance")]
public Int32 Chance { get; set;}

[REDProp("checkRotation")]
public bool CheckRotation { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

#endregion
}
}