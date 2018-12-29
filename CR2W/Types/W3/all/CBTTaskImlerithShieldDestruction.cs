using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskImlerithShieldDestruction : IBehTreeTask
{
#region RED Properties

[REDProp("firstTreshold")]
public float FirstTreshold { get; set;}

[REDProp("secondTreshold")]
public float SecondTreshold { get; set;}

[REDProp("thirdTreshold")]
public float ThirdTreshold { get; set;}

[REDProp("finalTreshold")]
public float FinalTreshold { get; set;}

[REDProp("dropShield")]
public bool DropShield { get; set;}

[REDProp("shield")]
public Handle<CEntity> Shield { get; set;}

[REDProp("shieldState")]
public Int32 ShieldState { get; set;}

#endregion
}
}