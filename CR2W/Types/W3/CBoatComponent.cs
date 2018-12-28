using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBoatComponent : CVehicleComponent
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

[REDProp("user")]
public Handle<CActor> User { get; set;}

[REDProp("sailDir")]
public float SailDir { get; set;}

[REDProp("mountAnimationFinished")]
public bool MountAnimationFinished { get; set;}

[REDProp("collisionNames")]
public Array<CName> CollisionNames { get; set;}

#endregion
}
}