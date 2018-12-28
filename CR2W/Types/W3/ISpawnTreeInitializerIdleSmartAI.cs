using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class ISpawnTreeInitializerIdleSmartAI : CSpawnTreeInitializerIdleAI
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("dynamicTreeParameterName")]
public CName DynamicTreeParameterName { get; set;}

[REDProp("subInitializer")]
public Handle<ISpawnTreeInitializer> SubInitializer { get; set;}

#endregion
}
}