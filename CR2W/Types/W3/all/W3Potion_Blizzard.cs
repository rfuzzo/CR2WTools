using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Potion_Blizzard : CBaseGameplayEffect
{
#region RED Properties

[REDProp("slowdownCauserIds")]
public Array<Int32> SlowdownCauserIds { get; set;}

[REDProp("slowdownFactor")]
public float SlowdownFactor { get; set;}

[REDProp("currentSlowMoDuration")]
public float CurrentSlowMoDuration { get; set;}

[REDProp("SLOW_MO_DURATION")]
public float SLOW_MO_DURATION { get; set;}

#endregion
}
}