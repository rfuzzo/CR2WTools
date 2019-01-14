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
public class CMergedWorldGeometryEntity : CEntity
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

[REDProp("components", 2,0)]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("sourceDataHash")]
public UInt64 SourceDataHash { get; set;}

[REDProp("worldBounds")]
public Box WorldBounds { get; set;}

[REDProp("gridCoordinates")]
public CMergedWorldGeometryGridCoordinates GridCoordinates { get; set;}

[REDProp("statsDataSize")]
public UInt32 StatsDataSize { get; set;}

[REDProp("statsNumTriangles")]
public UInt32 StatsNumTriangles { get; set;}

[REDProp("statsNumVertices")]
public UInt32 StatsNumVertices { get; set;}

#endregion
}
}