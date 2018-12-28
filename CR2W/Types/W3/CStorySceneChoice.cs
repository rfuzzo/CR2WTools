using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneChoice : CStorySceneElement
{
#region RED Properties

[REDProp("elementID")]
public string ElementID { get; set;}

[REDProp("approvedDuration")]
public float ApprovedDuration { get; set;}

[REDProp("isCopy")]
public bool IsCopy { get; set;}

[REDProp("choiceLines")]
public Array<Ptr<CStorySceneChoiceLine>> ChoiceLines { get; set;}

[REDProp("timeLimit")]
public float TimeLimit { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("isLooped")]
public bool IsLooped { get; set;}

[REDProp("questChoice")]
public bool QuestChoice { get; set;}

[REDProp("showLastLine")]
public bool ShowLastLine { get; set;}

[REDProp("alternativeUI")]
public bool AlternativeUI { get; set;}

#endregion
}
}