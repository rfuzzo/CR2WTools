using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CLightEntitySimpleWithEffectImmunity : CLightEntitySimple
{
#region RED Properties

[REDProp("effectImmunity")]
public EEffectType EffectImmunity { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("areaComponent")]
public Handle<CTriggerAreaComponent> AreaComponent { get; set;}

#endregion
}
}