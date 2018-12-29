using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIExecuteRangeAttackAction : IAIActionTree
{
#region RED Properties

[REDProp("attackParameter")]
public EAttackType AttackParameter { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("projectileName")]
public CName ProjectileName { get; set;}

#endregion
}
}