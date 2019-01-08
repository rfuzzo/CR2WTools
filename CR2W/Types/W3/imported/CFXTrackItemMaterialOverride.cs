using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXTrackItemMaterialOverride : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("material")]
public Handle<IMaterial> Material { get; set;}

[REDProp("exclusionTag")]
public CName ExclusionTag { get; set;}

[REDProp("drawOriginal")]
public bool DrawOriginal { get; set;}

[REDProp("includeList", 2,0)]
public Array<CName> IncludeList { get; set;}

[REDProp("excludeList", 2,0)]
public Array<CName> ExcludeList { get; set;}

[REDProp("forceMeshAlternatives")]
public bool ForceMeshAlternatives { get; set;}

#endregion
}
}