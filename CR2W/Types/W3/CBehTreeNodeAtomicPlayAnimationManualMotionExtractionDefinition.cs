using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeAtomicPlayAnimationManualMotionExtractionDefinition : CBehTreeNodeAtomicActionDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("loopIterations")]
public uint LoopIterations { get; set;}

[REDProp("isTransitionAnimation")]
public bool IsTransitionAnimation { get; set;}

#endregion
}
}