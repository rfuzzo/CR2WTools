using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_chosenLanguage : CQuestScriptedCondition
{
#region RED Properties

[REDProp("ChoosenTextLanguage")]
public ECheckedLanguage ChoosenTextLanguage { get; set;}

[REDProp("ChoosenSpeechLanguage")]
public ECheckedLanguage ChoosenSpeechLanguage { get; set;}

[REDProp("checkFor")]
public ELanguageCheckType CheckFor { get; set;}

#endregion
}
}