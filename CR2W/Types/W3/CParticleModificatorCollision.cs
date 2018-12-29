using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CParticleModificatorCollision : IParticleModificator
{
#region RED Properties

[REDProp("editorName")]
public string EditorName { get; set;}

[REDProp("editorColor")]
public Color EditorColor { get; set;}

[REDProp("editorGroup")]
public string EditorGroup { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("isShowing")]
public bool IsShowing { get; set;}

[REDProp("isSelected")]
public bool IsSelected { get; set;}

[REDProp("seed")]
public uint Seed { get; set;}

[REDProp("triggeringCollisionGroupNames")]
public Array<CName> TriggeringCollisionGroupNames { get; set;}

[REDProp("dynamicFriction")]
public float DynamicFriction { get; set;}

[REDProp("staticFriction")]
public float StaticFriction { get; set;}

[REDProp("restition")]
public float Restition { get; set;}

[REDProp("velocityDamp")]
public float VelocityDamp { get; set;}

[REDProp("disableGravity")]
public bool DisableGravity { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("killWhenCollide")]
public bool KillWhenCollide { get; set;}

/*[REDProp("Use Gpu Simulation If Avaible")]
public bool Use Gpu Simulation If Avaible { get; set;}*/

#endregion
}
}