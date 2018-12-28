using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSNCondition : IMoveSNComposite
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("children")]
public Array<Ptr<IMoveSteeringNode>> Children { get; set;}

[REDProp("condition")]
public Ptr<IMoveSteeringCondition> Condition { get; set;}

[REDProp("invertCondition")]
public bool InvertCondition { get; set;}

#endregion
}
}