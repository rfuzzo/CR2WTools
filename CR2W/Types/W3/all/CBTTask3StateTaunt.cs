using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateTaunt : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("tauntType")]
public ETauntType TauntType { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("minDuration")]
public float MinDuration { get; set;}

[REDProp("maxDuration")]
public float MaxDuration { get; set;}

[REDProp("res")]
public bool Res { get; set;}

#endregion
}
}