using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MusicBandActivatorArea : CEntity
{
#region RED Properties

[REDProp("musiciansTag")]
public CName MusiciansTag { get; set;}

[REDProp("interiorSoundEmitter")]
public Handle<CEntityTemplate> InteriorSoundEmitter { get; set;}

[REDProp("exteriorSoundEmitter")]
public Handle<CEntityTemplate> ExteriorSoundEmitter { get; set;}

[REDProp("exterior")]
public bool Exterior { get; set;}

[REDProp("minimalNumberOfMusicions")]
public Int32 MinimalNumberOfMusicions { get; set;}

[REDProp("activeSoundEmitter")]
public Handle<CEntity> ActiveSoundEmitter { get; set;}

[REDProp("activeMusician")]
public Handle<CEntity> ActiveMusician { get; set;}

[REDProp("activeMusicians")]
public Array<Handle<CEntity>> ActiveMusicians { get; set;}

[REDProp("activeArea")]
public Handle<CTriggerAreaComponent> ActiveArea { get; set;}

[REDProp("jobTreeType")]
public EJobTreeType JobTreeType { get; set;}

#endregion
}
}