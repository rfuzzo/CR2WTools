using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SPhysicsDestructionAdditionalInfo 
{
#region RED Properties

[REDProp("initialVelocity")]
public Vector InitialVelocity { get; set;}

[REDProp("overrideCollisionMasks")]
public bool OverrideCollisionMasks { get; set;}

[REDProp("m_collisionType")]
public CPhysicalCollision M_collisionType { get; set;}

#endregion
}
}