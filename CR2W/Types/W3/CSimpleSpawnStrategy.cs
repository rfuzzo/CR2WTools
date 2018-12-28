using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSimpleSpawnStrategy : ISpawnTreeSpawnStrategy
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("enablePooling")]
public bool EnablePooling { get; set;}

[REDProp("overflowPoolRange")]
public float OverflowPoolRange { get; set;}

[REDProp("minSpawnRange")]
public float MinSpawnRange { get; set;}

[REDProp("visibilityTestRange")]
public float VisibilityTestRange { get; set;}

[REDProp("maxSpawnRange")]
public float MaxSpawnRange { get; set;}

[REDProp("canPoolOnSight")]
public bool CanPoolOnSight { get; set;}

[REDProp("minPoolRange")]
public float MinPoolRange { get; set;}

[REDProp("forcePoolRange")]
public float ForcePoolRange { get; set;}

#endregion
}
}