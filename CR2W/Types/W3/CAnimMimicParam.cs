using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimMimicParam : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("animationSets")]
public Array<Handle<CSkeletalAnimationSet>> AnimationSets { get; set;}

[REDProp("behaviorInstanceSlots")]
public Array<SBehaviorGraphInstanceSlot> BehaviorInstanceSlots { get; set;}

#endregion
}
}