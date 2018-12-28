using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnTreeInitializerAddTag : ISpawnTreeInitializer
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("tag")]
public TagList Tag { get; set;}

[REDProp("onlySetOnSpawnAppearance")]
public bool OnlySetOnSpawnAppearance { get; set;}

#endregion
}
}