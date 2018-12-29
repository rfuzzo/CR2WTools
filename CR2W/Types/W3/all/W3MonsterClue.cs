using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MonsterClue : W3AnimationInteractionEntity
{
#region RED Properties

[REDProp("isAvailable")]
public bool IsAvailable { get; set;}

[REDProp("isInteractive")]
public bool IsInteractive { get; set;}

[REDProp("isReusable")]
public bool IsReusable { get; set;}

[REDProp("isVisible")]
public bool IsVisible { get; set;}

[REDProp("isIgnoringFM")]
public bool IsIgnoringFM { get; set;}

[REDProp("playerVoiceset")]
public EPlayerVoicesetType PlayerVoiceset { get; set;}

[REDProp("clueEntries")]
public Array<string> ClueEntries { get; set;}

[REDProp("maxDetectionDistance")]
public float MaxDetectionDistance { get; set;}

[REDProp("testLineOfSight")]
public bool TestLineOfSight { get; set;}

[REDProp("medallionVibration")]
public bool MedallionVibration { get; set;}

[REDProp("medallionVibrationDistance")]
public float MedallionVibrationDistance { get; set;}

[REDProp("medallionVibrationBehavior")]
public EFocusClueMedallionReaction MedallionVibrationBehavior { get; set;}

[REDProp("medallionVibratedEver")]
public bool MedallionVibratedEver { get; set;}

[REDProp("medallionVibratedInSession")]
public bool MedallionVibratedInSession { get; set;}

[REDProp("accuracyTreshold")]
public float AccuracyTreshold { get; set;}

[REDProp("eventOnDetected")]
public Array<Handle<IPerformableAction>> EventOnDetected { get; set;}

[REDProp("detectionDelay")]
public float DetectionDelay { get; set;}

[REDProp("wasDetected")]
public bool WasDetected { get; set;}

[REDProp("wasSeen")]
public bool WasSeen { get; set;}

[REDProp("isVisibleAsClue")]
public bool IsVisibleAsClue { get; set;}

[REDProp("linkedFocusArea")]
public Handle<W3FocusAreaTrigger> LinkedFocusArea { get; set;}

[REDProp("dimmingStarted")]
public bool DimmingStarted { get; set;}

[REDProp("focusModeController")]
public Handle<CFocusModeController> FocusModeController { get; set;}

[REDProp("INTERACTION_COMPONENT_NAME")]
public string INTERACTION_COMPONENT_NAME { get; set;}

#endregion
}
}