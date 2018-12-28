using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQCDistanceTo : IActorConditionType
{
#region RED Properties

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("targetNodeTag")]
public CName TargetNodeTag { get; set;}

[REDProp("compareFunc")]
public ECompareFunc CompareFunc { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

#endregion
}
}