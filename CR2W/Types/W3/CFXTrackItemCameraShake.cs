using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFXTrackItemCameraShake : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("effectFullForceRadius")]
public float EffectFullForceRadius { get; set;}

[REDProp("effectMaxRadius")]
public float EffectMaxRadius { get; set;}

[REDProp("shakeType")]
public CName ShakeType { get; set;}

#endregion
}
}