using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMajorPlaceOfPowerEntityStatePlaceOfPower_Channeling : CScriptableState
{
#region RED Properties

[REDProp("channelingStartTime")]
public float ChannelingStartTime { get; set;}

#endregion
}
}