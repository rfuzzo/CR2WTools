using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeInitializerGuardAreaByHandle : ISpawnTreeInitializerGuardAreaBase
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("pursuitRange")]
public float PursuitRange { get; set;}

[REDProp("guardArea")]
public EntityHandle GuardArea { get; set;}

[REDProp("pursuitArea")]
public EntityHandle PursuitArea { get; set;}

#endregion
}
}