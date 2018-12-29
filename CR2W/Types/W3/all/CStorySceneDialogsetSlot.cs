using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneDialogsetSlot : CObject
{
#region RED Properties

[REDProp("slotNumber")]
public uint SlotNumber { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("slotPlacement")]
public EngineTransform SlotPlacement { get; set;}

[REDProp("actorName")]
public CName ActorName { get; set;}

[REDProp("actorVisibility")]
public bool ActorVisibility { get; set;}

[REDProp("actorStatus")]
public CName ActorStatus { get; set;}

[REDProp("actorEmotionalState")]
public CName ActorEmotionalState { get; set;}

[REDProp("actorPoseName")]
public CName ActorPoseName { get; set;}

[REDProp("actorMimicsEmotionalState")]
public CName ActorMimicsEmotionalState { get; set;}

[REDProp("actorMimicsLayer_Eyes")]
public CName ActorMimicsLayer_Eyes { get; set;}

[REDProp("actorMimicsLayer_Pose")]
public CName ActorMimicsLayer_Pose { get; set;}

[REDProp("actorMimicsLayer_Animation")]
public CName ActorMimicsLayer_Animation { get; set;}

[REDProp("actorMimicsLayer_Pose_Weight")]
public float ActorMimicsLayer_Pose_Weight { get; set;}

[REDProp("forceBodyIdleAnimation")]
public CName ForceBodyIdleAnimation { get; set;}

[REDProp("forceBodyIdleAnimationWeight")]
public float ForceBodyIdleAnimationWeight { get; set;}

[REDProp("actorState")]
public CName ActorState { get; set;}

[REDProp("ID")]
public CGUID ID { get; set;}

[REDProp("setupAction")]
public Array<Ptr<CStorySceneAction>> SetupAction { get; set;}

#endregion
}
}