using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeActorTaskRunFromDangerDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("dangerRadius")]
public float DangerRadius { get; set;}

[REDProp("fleeDistance")]
public float FleeDistance { get; set;}

[REDProp("pursue")]
public bool Pursue { get; set;}

#endregion
}
}