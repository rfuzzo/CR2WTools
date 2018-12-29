using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondMonsterTacticIsUsed : IBehTreeTask
{
#region RED Properties

[REDProp("tactic")]
public EMonsterTactic Tactic { get; set;}

[REDProp("distanceToCheck")]
public float DistanceToCheck { get; set;}

[REDProp("ignoreMyself")]
public bool IgnoreMyself { get; set;}

#endregion
}
}