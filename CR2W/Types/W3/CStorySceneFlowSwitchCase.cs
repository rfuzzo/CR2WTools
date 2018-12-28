using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneFlowSwitchCase : CObject
{
#region RED Properties

[REDProp("whenCondition")]
public Ptr<IQuestCondition> WhenCondition { get; set;}

[REDProp("thenLink")]
public Ptr<CStorySceneLinkElement> ThenLink { get; set;}

#endregion
}
}