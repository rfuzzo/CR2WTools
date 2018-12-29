using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondCleanShot : IBehTreeTask
{
#region RED Properties

[REDProp("doStaticTraceOnNavTestFailure")]
public bool DoStaticTraceOnNavTestFailure { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("target")]
public Handle<CNode> Target { get; set;}

[REDProp("ownerPos")]
public Vector OwnerPos { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("res")]
public bool Res { get; set;}

#endregion
}
}