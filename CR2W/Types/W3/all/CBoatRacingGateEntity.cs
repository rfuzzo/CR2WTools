using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBoatRacingGateEntity : CGameplayEntity
{
#region RED Properties

[REDProp("nextGate")]
public EntityHandle NextGate { get; set;}

[REDProp("factOnReaching")]
public string FactOnReaching { get; set;}

[REDProp("nextGateEntity")]
public Handle<CBoatRacingGateEntity> NextGateEntity { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("isReached")]
public bool IsReached { get; set;}

#endregion
}
}