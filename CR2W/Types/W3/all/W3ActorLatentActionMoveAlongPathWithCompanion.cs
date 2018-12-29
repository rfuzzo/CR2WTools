using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActorLatentActionMoveAlongPathWithCompanion : W3ActorLatentActionMoveAlongPath
{
#region RED Properties

[REDProp("companionTag")]
public CName CompanionTag { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("progressWhenCompanionIsAhead")]
public bool ProgressWhenCompanionIsAhead { get; set;}

#endregion
}
}