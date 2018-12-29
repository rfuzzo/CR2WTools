using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CIdleAIEntryGenerator : CSpawnTreeBaseEntryGenerator
{
#region RED Properties

[REDProp("commonSpawnParams")]
public SCreatureEntrySpawnerParams CommonSpawnParams { get; set;}

[REDProp("entries")]
public Array<SIdleAEntryGeneratorParam> Entries { get; set;}

#endregion
}
}