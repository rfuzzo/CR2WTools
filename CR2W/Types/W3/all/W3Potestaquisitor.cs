using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Potestaquisitor : W3QuestUsableItem
{
#region RED Properties

[REDProp("detectableTag")]
public CName DetectableTag { get; set;}

[REDProp("detectableRange")]
public float DetectableRange { get; set;}

[REDProp("closestRange")]
public float ClosestRange { get; set;}

[REDProp("potestaquisitorFact")]
public string PotestaquisitorFact { get; set;}

[REDProp("soundEffectType")]
public EFocusModeSoundEffectType SoundEffectType { get; set;}

[REDProp("effect")]
public CName Effect { get; set;}

[REDProp("registeredAnomalies")]
public Array<Handle<CGameplayEntity>> RegisteredAnomalies { get; set;}

[REDProp("previousClosestAnomaly")]
public Handle<CGameplayEntity> PreviousClosestAnomaly { get; set;}

#endregion
}
}