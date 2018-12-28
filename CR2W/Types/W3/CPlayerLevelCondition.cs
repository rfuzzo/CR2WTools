using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPlayerLevelCondition : ISpawnCondition
{
#region RED Properties

[REDProp("minLevel")]
public int MinLevel { get; set;}

[REDProp("maxLevel")]
public int MaxLevel { get; set;}

#endregion
}
}