using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActorLatentActionMoveAlongPathAwareOfTail : W3ActorLatentActionMoveAlongPath
{
#region RED Properties

[REDProp("tailTag")]
public CName TailTag { get; set;}

[REDProp("startMovementDistance")]
public float StartMovementDistance { get; set;}

[REDProp("stopDistance")]
public float StopDistance { get; set;}

#endregion
}
}