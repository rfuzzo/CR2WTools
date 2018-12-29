using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CGameplayFXMedalion : CEntity
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

[REDProp("components")]
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

[REDProp("beginRadius")]
public float BeginRadius { get; set;}

[REDProp("endRadius")]
public float EndRadius { get; set;}

[REDProp("ringRadiusTolerance")]
public float RingRadiusTolerance { get; set;}

[REDProp("debugLoop")]
public bool DebugLoop { get; set;}

[REDProp("distPerSec")]
public float DistPerSec { get; set;}

[REDProp("sustainTime")]
public float SustainTime { get; set;}

[REDProp("highlightTag")]
public CName HighlightTag { get; set;}

#endregion
}
}