using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHorseJumpTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("lastActivation")]
public float LastActivation { get; set;}

[REDProp("triggerHeading")]
public float TriggerHeading { get; set;}

[REDProp("playerHeading")]
public float PlayerHeading { get; set;}

[REDProp("angleDist")]
public float AngleDist { get; set;}

[REDProp("horse")]
public Handle<CGameplayEntity> Horse { get; set;}

[REDProp("horseComp")]
public Handle<W3HorseComponent> HorseComp { get; set;}

[REDProp("lastArea")]
public Handle<CTriggerAreaComponent> LastArea { get; set;}

#endregion
}
}