using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MedallionFX : CEntity
{
#region RED Properties

[REDProp("scaleVector")]
public Vector ScaleVector { get; set;}

[REDProp("medallionScaleRate")]
public float MedallionScaleRate { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("medallionComponent")]
public Handle<CComponent> MedallionComponent { get; set;}

#endregion
}
}