using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBiesChargeDef : CBTTask3StateAttackDef
{
#region RED Properties

[REDProp("endStuck")]
public EAttackType EndStuck { get; set;}

[REDProp("endHit")]
public EAttackType EndHit { get; set;}

[REDProp("stuckTime")]
public float StuckTime { get; set;}

#endregion
}
}