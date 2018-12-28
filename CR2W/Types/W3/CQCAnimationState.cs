using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQCAnimationState : IGameplayEntConditionType
{
#region RED Properties

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("isPlaying")]
public bool IsPlaying { get; set;}

#endregion
}
}