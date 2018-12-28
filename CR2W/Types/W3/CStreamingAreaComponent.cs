using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStreamingAreaComponent : CAreaComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("terrainSide")]
public EAreaTerrainSide TerrainSide { get; set;}

[REDProp("clippingMode")]
public EAreaClippingMode ClippingMode { get; set;}

[REDProp("clippingAreaTags")]
public TagList ClippingAreaTags { get; set;}

[REDProp("saveShapeToLayer")]
public bool SaveShapeToLayer { get; set;}

[REDProp("localPoints")]
public Array<Vector> LocalPoints { get; set;}

[REDProp("worldPoints")]
public Array<Vector> WorldPoints { get; set;}

[REDProp("testInEditor")]
public bool TestInEditor { get; set;}

#endregion
}
}