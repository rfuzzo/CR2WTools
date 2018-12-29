using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMultiRangeSpawnStrategy : ISpawnTreeSpawnStrategy
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

[REDProp("primaryMinSpawnRange")]
public float PrimaryMinSpawnRange { get; set;}

[REDProp("primaryMaxSpawnRange")]
public float PrimaryMaxSpawnRange { get; set;}

[REDProp("visibilityTestRange")]
public float VisibilityTestRange { get; set;}

[REDProp("primaryMinPoolRange")]
public float PrimaryMinPoolRange { get; set;}

[REDProp("orientedRanges")]
public Array<SSpawnStrategyRange> OrientedRanges { get; set;}

[REDProp("canPoolOnSight")]
public bool CanPoolOnSight { get; set;}

[REDProp("forcePoolRange")]
public float ForcePoolRange { get; set;}

[REDProp("poolDelay")]
public float PoolDelay { get; set;}

#endregion
}
}