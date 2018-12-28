using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnConditionFact : ISpawnCondition
{
#region RED Properties

[REDProp("fact")]
public string Fact { get; set;}

[REDProp("value")]
public int Value { get; set;}

[REDProp("compare")]
public ECompareFunc Compare { get; set;}

#endregion
}
}