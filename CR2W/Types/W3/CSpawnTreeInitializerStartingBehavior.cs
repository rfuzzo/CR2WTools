using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSpawnTreeInitializerStartingBehavior : CSpawnTreeInitializerBaseStartingBehavior
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("dynamicTreeParameterName")]
public CName DynamicTreeParameterName { get; set;}

[REDProp("runBehaviorOnSpawn")]
public bool RunBehaviorOnSpawn { get; set;}

[REDProp("runBehaviorOnActivation")]
public bool RunBehaviorOnActivation { get; set;}

[REDProp("runBehaviorOnLoading")]
public bool RunBehaviorOnLoading { get; set;}

[REDProp("actionPriority")]
public ETopLevelAIPriorities ActionPriority { get; set;}

#endregion
}
}