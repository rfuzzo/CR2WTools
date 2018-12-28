using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4QuestDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("quest")]
public Handle<CQuest> Quest { get; set;}

[REDProp("taintFact")]
public CName TaintFact { get; set;}

[REDProp("sceneVoiceTagsTableFilePath")]
public string SceneVoiceTagsTableFilePath { get; set;}

[REDProp("questLevelsFilePath")]
public string QuestLevelsFilePath { get; set;}

#endregion
}
}