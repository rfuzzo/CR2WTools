using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CTriggerAreaExpansionPackComponent : CTriggerAreaComponent
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

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("includedChannels")]
public ETriggerChannel IncludedChannels { get; set;}

[REDProp("excludedChannels")]
public ETriggerChannel ExcludedChannels { get; set;}

[REDProp("triggerPriority")]
public uint TriggerPriority { get; set;}

[REDProp("enableCCD")]
public bool EnableCCD { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("deactivateTime")]
public int DeactivateTime { get; set;}

#endregion
}
}