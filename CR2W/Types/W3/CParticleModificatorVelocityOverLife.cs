using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CParticleModificatorVelocityOverLife : IParticleModificator
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

[REDProp("velocity")]
public Ptr<IEvaluatorVector> Velocity { get; set;}

[REDProp("modulate")]
public bool Modulate { get; set;}

[REDProp("absolute")]
public bool Absolute { get; set;}

#endregion
}
}