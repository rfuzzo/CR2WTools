using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIWanderTree : CAIIdleTree
{
#region RED Properties

[REDProp("wanderMoveSpeed")]
public float WanderMoveSpeed { get; set;}

[REDProp("wanderMoveType")]
public EMoveType WanderMoveType { get; set;}

[REDProp("wanderMaxDistance")]
public float WanderMaxDistance { get; set;}

#endregion
}
}