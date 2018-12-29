using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeGreetingReactionSceneDecoratorDefinition : CBehTreeNodeReactionSceneDefinitionDecorator
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("forwardAvailability")]
public bool ForwardAvailability { get; set;}

[REDProp("forwardTestIfNotAvailable")]
public bool ForwardTestIfNotAvailable { get; set;}

[REDProp("invertAvailability")]
public bool InvertAvailability { get; set;}

[REDProp("skipIfActive")]
public bool SkipIfActive { get; set;}

[REDProp("eventName")]
public CBehTreeValCName EventName { get; set;}

[REDProp("cooldownDistance")]
public CBehTreeValFloat CooldownDistance { get; set;}

[REDProp("cooldownTimeout")]
public CBehTreeValFloat CooldownTimeout { get; set;}

[REDProp("dontSetActionTargetEdit")]
public CBehTreeValBool DontSetActionTargetEdit { get; set;}

[REDProp("roles")]
public Array<CName> Roles { get; set;}

[REDProp("inInWorkBranch")]
public CBehTreeValBool InInWorkBranch { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

#endregion
}
}