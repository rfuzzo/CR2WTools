using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneControlPart : CStorySceneLinkElement
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

#endregion
}
}