using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphSynchronizeAnimationsToParentNode : CBehaviorGraphNode
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

/*[REDProp("Synchronize to input")]
public bool Synchronize to input { get; set;}

[REDProp("Auto use anims with same name")]
public bool Auto use anims with same name { get; set;}

[REDProp("Animation stay multiplier")]
public float Animation stay multiplier { get; set;}

[REDProp("Sync to normal/full body anims")]
public bool Sync to normal/full body anims { get; set;}

[REDProp("Sync to overlay body anims")]
public bool Sync to overlay body anims { get; set;}

[REDProp("Skip normal/full body anims when syncing overlay anims")]
public bool Skip normal/full body anims when syncing overlay anims { get; set;}

[REDProp("Sync default to any looped anim found")]
public bool Sync default to any looped anim found { get; set;}*/

[REDProp("Default")]
public SSynchronizeAnimationToParentDefinition Default { get; set;}

[REDProp("Anims")]
public Array<SSynchronizeAnimationToParentDefinition> Anims { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

#endregion
}
}