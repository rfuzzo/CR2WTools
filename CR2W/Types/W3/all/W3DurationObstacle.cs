using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DurationObstacle : CGameplayEntity
{
#region RED Properties

[REDProp("lifeTimeDuration")]
public SRangeF LifeTimeDuration { get; set;}

[REDProp("disappearanceEffectDuration")]
public float DisappearanceEffectDuration { get; set;}

[REDProp("disappearEffectName")]
public CName DisappearEffectName { get; set;}

[REDProp("simplyStopEffect")]
public bool SimplyStopEffect { get; set;}

#endregion
}
}