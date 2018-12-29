using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4MappinsDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("worldFilePath")]
public Soft<CWorld> WorldFilePath { get; set;}

[REDProp("mappinsFilePath")]
public Soft<CEntityMapPinsResource> MappinsFilePath { get; set;}

[REDProp("questMappinsFilePath")]
public Soft<CQuestMapPinsResource> QuestMappinsFilePath { get; set;}

#endregion
}
}