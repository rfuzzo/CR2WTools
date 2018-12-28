using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphOffensiveComboStateNode : CBehaviorGraphComboStateNode
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

[REDProp("mimicInputs")]
public Array<CName> MimicInputs { get; set;}

[REDProp("vectorValueInputs")]
public Array<CName> VectorValueInputs { get; set;}

[REDProp("groups")]
public TagList Groups { get; set;}

[REDProp("behaviorGraphSyncInfo")]
public SBehaviorGraphStateBehaviorGraphSyncInfo BehaviorGraphSyncInfo { get; set;}

[REDProp("cachedStateTransitions")]
public Array<Ptr<CBehaviorGraphStateTransitionNode>> CachedStateTransitions { get; set;}

[REDProp("isConnected")]
public bool IsConnected { get; set;}

[REDProp("comboWays")]
public Array<SBehaviorComboWay> ComboWays { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("blendForAnim")]
public float BlendForAnim { get; set;}

[REDProp("blendInternal")]
public float BlendInternal { get; set;}

[REDProp("maxLevel")]
public uint MaxLevel { get; set;}

[REDProp("comboEvent")]
public CName ComboEvent { get; set;}

[REDProp("finishedEvent")]
public CName FinishedEvent { get; set;}

[REDProp("varComboWay")]
public CName VarComboWay { get; set;}

[REDProp("varComboDist")]
public CName VarComboDist { get; set;}

[REDProp("varComboDir")]
public CName VarComboDir { get; set;}

[REDProp("slotA")]
public Ptr<CBehaviorGraphAnimationNode> SlotA { get; set;}

[REDProp("slotB")]
public Ptr<CBehaviorGraphAnimationNode> SlotB { get; set;}

[REDProp("allowAttackEvent")]
public CName AllowAttackEvent { get; set;}

#endregion
}
}