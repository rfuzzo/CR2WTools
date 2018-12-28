using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAIReaction : CObject
{
#region RED Properties

[REDProp("fieldName")]
public CName FieldName { get; set;}

[REDProp("cooldownTime")]
public float CooldownTime { get; set;}

[REDProp("visibilityTest")]
public EVisibilityTest VisibilityTest { get; set;}

[REDProp("range")]
public SAIReactionRange Range { get; set;}

[REDProp("factTest")]
public SAIReactionFactTest FactTest { get; set;}

[REDProp("condition")]
public Ptr<IReactionCondition> Condition { get; set;}

[REDProp("action")]
public Ptr<IReactionAction> Action { get; set;}

#endregion
}
}