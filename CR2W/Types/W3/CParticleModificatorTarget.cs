using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CParticleModificatorTarget : IParticleModificator
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

[REDProp("position")]
public Ptr<IEvaluatorVector> Position { get; set;}

[REDProp("forceScale")]
public Ptr<IEvaluatorFloat> ForceScale { get; set;}

[REDProp("killRadius")]
public Ptr<IEvaluatorFloat> KillRadius { get; set;}

[REDProp("maxForce")]
public float MaxForce { get; set;}

#endregion
}
}