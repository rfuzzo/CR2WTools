using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGuard : IBehTreeTask
{
#region RED Properties

[REDProp("guardArea")]
public Handle<CAreaComponent> GuardArea { get; set;}

[REDProp("pursuitArea")]
public Handle<CAreaComponent> PursuitArea { get; set;}

[REDProp("pursuitRange")]
public float PursuitRange { get; set;}

[REDProp("retreatType")]
public EMoveType RetreatType { get; set;}

[REDProp("retreatSpeed")]
public float RetreatSpeed { get; set;}

[REDProp("intruderTestFrequency")]
public float IntruderTestFrequency { get; set;}

[REDProp("intruderTestTimeout")]
public float IntruderTestTimeout { get; set;}

[REDProp("guardState")]
public EGuardState GuardState { get; set;}

[REDProp("intruders")]
public Array<Handle<CGameplayEntity>> Intruders { get; set;}

[REDProp("target")]
public Handle<CActor> Target { get; set;}

#endregion
}
}