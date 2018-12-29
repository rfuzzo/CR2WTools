using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ISpawnTreeCreatePortalEntityInitializer : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("entityToCreate")]
public Handle<CEntityTemplate> EntityToCreate { get; set;}

[REDProp("spawnOffset")]
public Vector SpawnOffset { get; set;}

#endregion
}
}