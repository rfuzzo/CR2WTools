using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class ISpawnTreeInitializerToggleBehavior : ISpawnTreeInitializer
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("behaviorSwitchName")]
public CName BehaviorSwitchName { get; set;}

[REDProp("enableBehavior")]
public bool EnableBehavior { get; set;}

#endregion
}
}