using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CParticleModificatorTextureAnimation : IParticleModificator
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

[REDProp("initialFrame")]
public Ptr<IEvaluatorFloat> InitialFrame { get; set;}

[REDProp("animationSpeed")]
public Ptr<IEvaluatorFloat> AnimationSpeed { get; set;}

[REDProp("animationMode")]
public ETextureAnimationMode AnimationMode { get; set;}

#endregion
}
}