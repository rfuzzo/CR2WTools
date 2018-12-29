using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSpawnTreeInitializerRainHandler : ISpawnTreeInitializer
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("ratioWhenRaining")]
public float RatioWhenRaining { get; set;}

#endregion
}
}