using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterTauntParams : CAITauntParameters
{
#region RED Properties

[REDProp("stopTauntingDistance")]
public float StopTauntingDistance { get; set;}

[REDProp("tauntDelay")]
public float TauntDelay { get; set;}

[REDProp("forceAttackDelay")]
public float ForceAttackDelay { get; set;}

[REDProp("useSurround")]
public bool UseSurround { get; set;}

[REDProp("chanceToMove")]
public float ChanceToMove { get; set;}

#endregion
}
}