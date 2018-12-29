using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4QuestListMenu : CR4Menu
{
#region RED Properties

[REDProp("KEY_QUEST_LIST")]
public string KEY_QUEST_LIST { get; set;}

[REDProp("REWARDS_SIZE")]
public Int32 REWARDS_SIZE { get; set;}

[REDProp("m_journalManager")]
public Handle<CWitcherJournalManager> M_journalManager { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("allQuests")]
public Array<Handle<CJournalBase>> AllQuests { get; set;}

[REDProp("_currentQuestID")]
public Int32 _currentQuestID { get; set;}

#endregion
}
}