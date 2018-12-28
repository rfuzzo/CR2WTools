using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneOutput : CStorySceneControlPart
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("questOutput")]
public bool QuestOutput { get; set;}

[REDProp("endsWithBlackscreen")]
public bool EndsWithBlackscreen { get; set;}

[REDProp("blackscreenColor")]
public Color BlackscreenColor { get; set;}

[REDProp("gameplayCameraBlendTime")]
public float GameplayCameraBlendTime { get; set;}

[REDProp("environmentLightsBlendTime")]
public float EnvironmentLightsBlendTime { get; set;}

[REDProp("gameplayCameraUseFocusTarget")]
public bool GameplayCameraUseFocusTarget { get; set;}

#endregion
}
}