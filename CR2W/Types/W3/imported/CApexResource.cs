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
public class CApexResource : CMeshTypeResource
{
#region RED Properties

[REDProp("materials", 2,0)]
public Array<Handle<IMaterial>> Materials { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("isTwoSided")]
public bool IsTwoSided { get; set;}

[REDProp("apexBinaryAsset", 95,0)]
public Array<byte> ApexBinaryAsset { get; set;}

[REDProp("apexMaterialNames", 2,0)]
public Array<String> ApexMaterialNames { get; set;}

[REDProp("shadowDistance")]
public float ShadowDistance { get; set;}

#endregion
}
}