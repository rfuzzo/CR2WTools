using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFurLevelOfDetail 
{
#region RED Properties

[REDProp("enableLOD")]
public bool EnableLOD { get; set;}

[REDProp("culling")]
public SFurCulling Culling { get; set;}

[REDProp("distanceLOD")]
public SFurDistanceLOD DistanceLOD { get; set;}

[REDProp("detailLOD")]
public SFurDetailLOD DetailLOD { get; set;}

[REDProp("priority")]
public uint Priority { get; set;}

#endregion
}
}