using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBaseAICombatStorage : IScriptable
{
#region RED Properties

[REDProp("isAttacking")]
public bool IsAttacking { get; set;}

[REDProp("isCharging")]
public bool IsCharging { get; set;}

[REDProp("isTaunting")]
public bool IsTaunting { get; set;}

[REDProp("isShooting")]
public bool IsShooting { get; set;}

[REDProp("isAiming")]
public bool IsAiming { get; set;}

[REDProp("isInImportantAnim")]
public bool IsInImportantAnim { get; set;}

[REDProp("preCombatWarning")]
public bool PreCombatWarning { get; set;}

[REDProp("atackTimeStamp")]
public float AtackTimeStamp { get; set;}

[REDProp("tauntTimeStamp")]
public float TauntTimeStamp { get; set;}

[REDProp("CSArray")]
public Array<CriticalStateStruct> CSArray { get; set;}

#endregion
}
}