using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NoticeBoard : CR4MapPinEntity
{
#region RED Properties

[REDProp("visited")]
public bool Visited { get; set;}

[REDProp("addedNotes")]
public Array<ErrandDetailsList> AddedNotes { get; set;}

[REDProp("fluffNotices")]
public Array<string> FluffNotices { get; set;}

[REDProp("entitiesToBeShown")]
public Array<CName> EntitiesToBeShown { get; set;}

[REDProp("questEntitiesToBeShown")]
public Array<CName> QuestEntitiesToBeShown { get; set;}

[REDProp("questNonActorEntitiesToBeShown")]
public Array<CName> QuestNonActorEntitiesToBeShown { get; set;}

[REDProp("InteractionSpawnDelayTime")]
public float InteractionSpawnDelayTime { get; set;}

[REDProp("backgroundOverride")]
public string BackgroundOverride { get; set;}

[REDProp("factAddedOnDiscovery")]
public CName FactAddedOnDiscovery { get; set;}

[REDProp("noticeboardDisabled")]
public bool NoticeboardDisabled { get; set;}

[REDProp("activeErrands")]
public Array<ErrandDetailsList> ActiveErrands { get; set;}

[REDProp("updatingInteraction")]
public bool UpdatingInteraction { get; set;}

[REDProp("errandPositionName")]
public string ErrandPositionName { get; set;}

[REDProp("MAX_DISPLAYED_ERRANDS")]
public Int32 MAX_DISPLAYED_ERRANDS { get; set;}

[REDProp("lastTimeInteracted")]
public GameTime LastTimeInteracted { get; set;}

[REDProp("interactionComponent")]
public Handle<CInteractionComponent> InteractionComponent { get; set;}

[REDProp("hack_updateTriesLeft")]
public Int32 Hack_updateTriesLeft { get; set;}

[REDProp("hack_isTryingUpdate")]
public bool Hack_isTryingUpdate { get; set;}

[REDProp("hack_started")]
public bool Hack_started { get; set;}

[REDProp("hack_fromAreaEnter")]
public bool Hack_fromAreaEnter { get; set;}

#endregion
}
}