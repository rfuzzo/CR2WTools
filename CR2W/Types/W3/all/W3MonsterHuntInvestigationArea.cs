using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MonsterHuntInvestigationArea : CGameplayEntity
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("investigationMusicStartEvent")]
public string InvestigationMusicStartEvent { get; set;}

[REDProp("investigationMusicStopEvent")]
public string InvestigationMusicStopEvent { get; set;}

[REDProp("requiredTrackedQuest")]
public CName RequiredTrackedQuest { get; set;}

[REDProp("active")]
public bool Active { get; set;}

#endregion
}
}