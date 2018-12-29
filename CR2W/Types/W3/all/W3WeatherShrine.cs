using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WeatherShrine : CGameplayEntity
{
#region RED Properties

[REDProp("weatherBlendTime")]
public float WeatherBlendTime { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("prayerForSunAcceptedFX")]
public CName PrayerForSunAcceptedFX { get; set;}

[REDProp("prayerForStormAcceptedFX")]
public CName PrayerForStormAcceptedFX { get; set;}

[REDProp("price")]
public Int32 Price { get; set;}

#endregion
}
}