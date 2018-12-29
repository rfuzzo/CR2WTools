using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SonarEnttity : CEntity
{
#region RED Properties

[REDProp("scaleVector")]
public Vector ScaleVector { get; set;}

[REDProp("sonarScaleRate")]
public float SonarScaleRate { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("speedModifier")]
public float SpeedModifier { get; set;}

[REDProp("stopHighlightAfter")]
public float StopHighlightAfter { get; set;}

[REDProp("sonarComponent")]
public Handle<CComponent> SonarComponent { get; set;}

#endregion
}
}