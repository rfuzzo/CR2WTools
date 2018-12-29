using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPhantomComponent : CComponent
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

[REDProp("collisionGroupName")]
public CName CollisionGroupName { get; set;}

[REDProp("triggeringCollisionGroupNames")]
public Array<CName> TriggeringCollisionGroupNames { get; set;}

[REDProp("shapeType")]
public EPhantomShape ShapeType { get; set;}

[REDProp("shapeDimensions")]
public Vector ShapeDimensions { get; set;}

[REDProp("onTriggerEnteredScriptEvent")]
public CName OnTriggerEnteredScriptEvent { get; set;}

[REDProp("onTriggerExitedScriptEvent")]
public CName OnTriggerExitedScriptEvent { get; set;}

[REDProp("eventsCalledOnComponent")]
public bool EventsCalledOnComponent { get; set;}

[REDProp("useInQueries")]
public bool UseInQueries { get; set;}

[REDProp("meshCollision")]
public Handle<CMesh> MeshCollision { get; set;}

#endregion
}
}