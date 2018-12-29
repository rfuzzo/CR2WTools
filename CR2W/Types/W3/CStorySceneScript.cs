using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneScript : CStorySceneControlPart
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("functionName")]
public CName FunctionName { get; set;}

[REDProp("links")]
public Array<Ptr<CStorySceneLinkElement>> Links { get; set;}

#endregion
}
}