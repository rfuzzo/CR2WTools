using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class StorySceneExpectedActor 
{
#region RED Properties

[REDProp("voicetag")]
public CName Voicetag { get; set;}

[REDProp("actorTags")]
public TagList ActorTags { get; set;}

[REDProp("entityTemplate")]
public Soft<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("appearanceFilter")]
public Array<CName> AppearanceFilter { get; set;}

[REDProp("dontSearchByVoicetag")]
public bool DontSearchByVoicetag { get; set;}

[REDProp("alias")]
public string Alias { get; set;}

#endregion
}
}