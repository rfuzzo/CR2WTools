using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPlayPropertyAnimationAction : IEntityTargetingAction
{
#region RED Properties

[REDProp("entitySelectionType")]
public EEntityTargetingActionMechanism EntitySelectionType { get; set;}

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("loopCount")]
public uint LoopCount { get; set;}

[REDProp("lengthScale")]
public float LengthScale { get; set;}

[REDProp("mode")]
public EPropertyCurveMode Mode { get; set;}

#endregion
}
}