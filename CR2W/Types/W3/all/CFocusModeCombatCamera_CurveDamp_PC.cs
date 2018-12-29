using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFocusModeCombatCamera_CurveDamp_PC : CObject
{
#region RED Properties

[REDProp("pivotCurveName")]
public CName PivotCurveName { get; set;}

[REDProp("autoTimeUpdate")]
public bool AutoTimeUpdate { get; set;}

[REDProp("pivotDamper")]
public Handle<CurveDamper3d> PivotDamper { get; set;}

[REDProp("timeScale")]
public float TimeScale { get; set;}

#endregion
}
}