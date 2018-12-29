using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NPCBackgroundNew : CEntity
{
#region RED Properties

[REDProp("behaviorWorkNumber")]
public Int32 BehaviorWorkNumber { get; set;}

[REDProp("randomized")]
public bool Randomized { get; set;}

[REDProp("maxWorkNumber")]
public Int32 MaxWorkNumber { get; set;}

[REDProp("excludeIdle")]
public bool ExcludeIdle { get; set;}

#endregion
}
}