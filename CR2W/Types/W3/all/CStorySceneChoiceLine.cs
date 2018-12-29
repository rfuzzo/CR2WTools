using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneChoiceLine : CStorySceneLinkElement
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("choiceLine")]
public LocalizedString ChoiceLine { get; set;}

[REDProp("choiceComment")]
public LocalizedString ChoiceComment { get; set;}

[REDProp("questCondition")]
public Ptr<IQuestCondition> QuestCondition { get; set;}

[REDProp("memo")]
public Array<Ptr<ISceneChoiceMemo>> Memo { get; set;}

[REDProp("singleUseChoice")]
public bool SingleUseChoice { get; set;}

[REDProp("emphasisLine")]
public bool EmphasisLine { get; set;}

[REDProp("action")]
public Ptr<IStorySceneChoiceLineAction> Action { get; set;}

#endregion
}
}