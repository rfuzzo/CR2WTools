using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CApexResource : CMeshTypeResource
{
#region RED Properties

[REDProp("materials")]
public Array<Handle<IMaterial>> Materials { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("isTwoSided")]
public bool IsTwoSided { get; set;}

[REDProp("apexBinaryAsset")]
public Array<byte> ApexBinaryAsset { get; set;}

[REDProp("apexMaterialNames")]
public Array<string> ApexMaterialNames { get; set;}

[REDProp("shadowDistance")]
public float ShadowDistance { get; set;}

#endregion
}
}