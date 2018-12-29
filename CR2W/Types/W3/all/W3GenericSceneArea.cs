using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GenericSceneArea : CGameplayEntity
{
#region RED Properties

[REDProp("scenes")]
public Array<genericSceneDefinition> Scenes { get; set;}

[REDProp("forbiddenFact")]
public string ForbiddenFact { get; set;}

[REDProp("requiredFact")]
public string RequiredFact { get; set;}

[REDProp("npcSearchRange")]
public float NpcSearchRange { get; set;}

[REDProp("ignoreReplacers")]
public bool IgnoreReplacers { get; set;}

[REDProp("includeEnemyNPCs")]
public bool IncludeEnemyNPCs { get; set;}

[REDProp("includeQuestNPCs")]
public bool IncludeQuestNPCs { get; set;}

[REDProp("sceneDelay")]
public float SceneDelay { get; set;}

[REDProp("firstPlaySceneDelay")]
public float FirstPlaySceneDelay { get; set;}

[REDProp("currentSceneDelay")]
public float CurrentSceneDelay { get; set;}

#endregion
}
}