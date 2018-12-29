using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFocusModeCombatCamera_CurveDamp_Rot_MC : CFocusModeCombatCamera_CurveDamp_MC
{
#region RED Properties

[REDProp("rollCurveName")]
public CName RollCurveName { get; set;}

[REDProp("posCurveName")]
public CName PosCurveName { get; set;}

[REDProp("rollDamper")]
public Handle<AngleCurveDamper> RollDamper { get; set;}

[REDProp("posDamper")]
public Handle<CurveDamper3d> PosDamper { get; set;}

#endregion
}
}