using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_OverEncumbered : CBaseGameplayEffect
{
#region RED Properties

[REDProp("timeSinceLastMessage")]
public float TimeSinceLastMessage { get; set;}

[REDProp("OVERWEIGHT_MESSAGE_DELAY")]
public float OVERWEIGHT_MESSAGE_DELAY { get; set;}

#endregion
}
}