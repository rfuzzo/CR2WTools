using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBgNpc : CEntity
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

[REDProp("displayName")]
public LocalizedString DisplayName { get; set;}

[REDProp("voiceset")]
public Ptr<CVoicesetParam> Voiceset { get; set;}

[REDProp("headBoneIndex")]
public int HeadBoneIndex { get; set;}

[REDProp("jobTree")]
public Soft<CJobTree> JobTree { get; set;}

[REDProp("jobTrees")]
public Array<SBgNpcJobTree> JobTrees { get; set;}

[REDProp("category")]
public CName Category { get; set;}

[REDProp("collisionCapsule")]
public bool CollisionCapsule { get; set;}

[REDProp("originalTemplete")]
public Handle<CEntityTemplate> OriginalTemplete { get; set;}

#endregion
}
}