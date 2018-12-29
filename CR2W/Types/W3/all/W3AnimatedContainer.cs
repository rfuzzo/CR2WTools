using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AnimatedContainer : W3Container
{
#region RED Properties

[REDProp("animationForAllInteractions")]
public bool AnimationForAllInteractions { get; set;}

[REDProp("interactionName")]
public string InteractionName { get; set;}

[REDProp("holsterWeaponAtTheBeginning")]
public bool HolsterWeaponAtTheBeginning { get; set;}

[REDProp("interactionAnim")]
public EPlayerExplorationAction InteractionAnim { get; set;}

[REDProp("slotAnimName")]
public CName SlotAnimName { get; set;}

[REDProp("interactionAnimTime")]
public float InteractionAnimTime { get; set;}

[REDProp("desiredPlayerToEntityDistance")]
public float DesiredPlayerToEntityDistance { get; set;}

[REDProp("matchPlayerHeadingWithHeadingOfTheEntity")]
public bool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

[REDProp("attachThisObjectOnAnimEvent")]
public bool AttachThisObjectOnAnimEvent { get; set;}

[REDProp("attachSlotName")]
public CName AttachSlotName { get; set;}

[REDProp("attachAnimName")]
public CName AttachAnimName { get; set;}

[REDProp("detachAnimName")]
public CName DetachAnimName { get; set;}

[REDProp("objectAttached")]
public bool ObjectAttached { get; set;}

[REDProp("objectCachedPos")]
public Vector ObjectCachedPos { get; set;}

[REDProp("objectCachedRot")]
public EulerAngles ObjectCachedRot { get; set;}

#endregion
}
}