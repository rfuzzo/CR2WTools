using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class ISpawnTreeSpawnStrategy : ISpawnTreeInitializer
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

#endregion
}
}