using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHorseCorrectionTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("valueOnEnter")]
public bool ValueOnEnter { get; set;}

[REDProp("valueOnExit")]
public bool ValueOnExit { get; set;}

[REDProp("horse")]
public Handle<CGameplayEntity> Horse { get; set;}

[REDProp("horseComp")]
public Handle<W3HorseComponent> HorseComp { get; set;}

#endregion
}
}