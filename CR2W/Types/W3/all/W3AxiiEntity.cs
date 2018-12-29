using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AxiiEntity : W3SignEntity
{
#region RED Properties

[REDProp("effects")]
public Array<SAxiiEffects> Effects { get; set;}

[REDProp("projTemplate")]
public Handle<CEntityTemplate> ProjTemplate { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("projSpeed")]
public float ProjSpeed { get; set;}

[REDProp("targets")]
public Array<Handle<CActor>> Targets { get; set;}

[REDProp("orientationTarget")]
public Handle<CActor> OrientationTarget { get; set;}

#endregion
}
}