using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMagicMineEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("tellTime")]
public float TellTime { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("boatDamageVal")]
public float BoatDamageVal { get; set;}

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("mineTrigger")]
public Handle<CTriggerAreaComponent> MineTrigger { get; set;}

#endregion
}
}