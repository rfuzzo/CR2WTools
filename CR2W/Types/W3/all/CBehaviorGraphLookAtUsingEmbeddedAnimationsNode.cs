using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphLookAtUsingEmbeddedAnimationsNode : CBehaviorGraphLookAtUsingAnimationsCommonBaseNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedLookAtVariableNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedLookAtVariableNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("cachedLookAtBlendTimeNode")]
public Ptr<CBehaviorGraphValueNode> CachedLookAtBlendTimeNode { get; set;}

[REDProp("useHorizontalAnimations")]
public bool UseHorizontalAnimations { get; set;}

[REDProp("useVerticalAnimations")]
public bool UseVerticalAnimations { get; set;}

[REDProp("Pairs")]
public Array<SLookAtAnimationPairDefinition> Pairs { get; set;}

#endregion
}
}