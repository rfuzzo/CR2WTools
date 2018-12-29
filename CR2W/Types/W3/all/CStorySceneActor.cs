using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneActor : IStorySceneItem
{
#region RED Properties

[REDProp("id")]
public CName Id { get; set;}

[REDProp("actorTags")]
public TagList ActorTags { get; set;}

[REDProp("entityTemplate")]
public Soft<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("appearanceFilter")]
public Array<CName> AppearanceFilter { get; set;}

[REDProp("dontSearchByVoicetag")]
public bool DontSearchByVoicetag { get; set;}

[REDProp("useHiresShadows")]
public bool UseHiresShadows { get; set;}

[REDProp("forceSpawn")]
public bool ForceSpawn { get; set;}

[REDProp("useMimic")]
public bool UseMimic { get; set;}

[REDProp("alias")]
public string Alias { get; set;}

#endregion
}
}