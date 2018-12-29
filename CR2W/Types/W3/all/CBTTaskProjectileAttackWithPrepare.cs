using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskProjectileAttackWithPrepare : CBTTaskProjectileAttack
{
#region RED Properties

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("rawTarget")]
public bool RawTarget { get; set;}

[REDProp("shootInFront")]
public bool ShootInFront { get; set;}

[REDProp("shootInFrontOffset")]
public float ShootInFrontOffset { get; set;}

#endregion
}
}