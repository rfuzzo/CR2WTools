using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SVirtualControllerParams 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("localOffset")]
public Vector LocalOffset { get; set;}

[REDProp("localOffsetInModelSpace")]
public bool LocalOffsetInModelSpace { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("targetable")]
public bool Targetable { get; set;}

[REDProp("collisions")]
public bool Collisions { get; set;}

[REDProp("collisionResponse")]
public bool CollisionResponse { get; set;}

[REDProp("collisionGrabber")]
public bool CollisionGrabber { get; set;}

[REDProp("collisionGrabberGroupNames")]
public Array<CName> CollisionGrabberGroupNames { get; set;}

[REDProp("onCollisionEventName")]
public CName OnCollisionEventName { get; set;}

[REDProp("additionalRaycastCheck")]
public Vector AdditionalRaycastCheck { get; set;}

[REDProp("additionalRaycastCheckEventName")]
public CName AdditionalRaycastCheckEventName { get; set;}

#endregion
}
}