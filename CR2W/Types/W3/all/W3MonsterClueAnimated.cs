using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MonsterClueAnimated : W3MonsterClue
{
#region RED Properties

[REDProp("animation")]
public EMonsterClueAnim Animation { get; set;}

[REDProp("witnessWholeAnimation")]
public bool WitnessWholeAnimation { get; set;}

[REDProp("animStartEvent")]
public CName AnimStartEvent { get; set;}

[REDProp("animEndEvent")]
public CName AnimEndEvent { get; set;}

[REDProp("useAccuracyTest")]
public bool UseAccuracyTest { get; set;}

[REDProp("accuracyError")]
public float AccuracyError { get; set;}

[REDProp("stopAnimSoundEvent")]
public CName StopAnimSoundEvent { get; set;}

[REDProp("activatedByFact")]
public CName ActivatedByFact { get; set;}

[REDProp("spawnPosWasSaved")]
public bool SpawnPosWasSaved { get; set;}

[REDProp("spawnPos")]
public Vector SpawnPos { get; set;}

[REDProp("spawnRot")]
public EulerAngles SpawnRot { get; set;}

[REDProp("animStarted")]
public bool AnimStarted { get; set;}

#endregion
}
}