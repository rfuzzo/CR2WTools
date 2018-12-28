using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CVitalSpot : CObject
{
#region RED Properties

[REDProp("editorLabel")]
public CName EditorLabel { get; set;}

[REDProp("entitySlotName")]
public CName EntitySlotName { get; set;}

[REDProp("normal")]
public Vector Normal { get; set;}

[REDProp("cutDirection")]
public Vector CutDirection { get; set;}

[REDProp("vitalSpotEntry")]
public Handle<CJournalPath> VitalSpotEntry { get; set;}

[REDProp("hitReactionAnimation")]
public CName HitReactionAnimation { get; set;}

[REDProp("focusPointsCost")]
public float FocusPointsCost { get; set;}

[REDProp("destroyAfterExecution")]
public bool DestroyAfterExecution { get; set;}

[REDProp("gameplayEffects")]
public Array<Handle<IGameplayEffectExecutor>> GameplayEffects { get; set;}

[REDProp("enableConditions")]
public SVitalSpotEnableConditions EnableConditions { get; set;}

[REDProp("visualEffect")]
public CName VisualEffect { get; set;}

[REDProp("soundOnFocus")]
public string SoundOnFocus { get; set;}

[REDProp("soundOffFocus")]
public string SoundOffFocus { get; set;}

#endregion
}
}