using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneFlowCondition : CStorySceneControlPart
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("trueLink")]
public Ptr<CStorySceneLinkElement> TrueLink { get; set;}

[REDProp("falseLink")]
public Ptr<CStorySceneLinkElement> FalseLink { get; set;}

[REDProp("questCondition")]
public Ptr<IQuestCondition> QuestCondition { get; set;}

#endregion
}
}