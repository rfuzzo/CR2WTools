using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSwim : CExplorationStateAbstract
{
#region RED Properties

[REDProp("solveCollisionsForward")]
public bool SolveCollisionsForward { get; set;}

[REDProp("smoothPenetration")]
public bool SmoothPenetration { get; set;}

[REDProp("collisionUpOffset")]
public float CollisionUpOffset { get; set;}

[REDProp("collisionDistance")]
public float CollisionDistance { get; set;}

[REDProp("collisionRadius")]
public float CollisionRadius { get; set;}

[REDProp("collisionPenetrationMax")]
public float CollisionPenetrationMax { get; set;}

[REDProp("collisionPenetration")]
public Vector CollisionPenetration { get; set;}

[REDProp("smoothSpeed")]
public float SmoothSpeed { get; set;}

[REDProp("zeroVec")]
public Vector ZeroVec { get; set;}

#endregion
}
}