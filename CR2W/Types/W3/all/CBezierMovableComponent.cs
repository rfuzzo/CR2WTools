using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBezierMovableComponent : CSkeletalAnimatedComponent
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

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("animset")]
public Handle<CSkeletalAnimationSet> Animset { get; set;}

[REDProp("controller")]
public Ptr<IAnimationController> Controller { get; set;}

[REDProp("processEvents")]
public bool ProcessEvents { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

#endregion
}
}