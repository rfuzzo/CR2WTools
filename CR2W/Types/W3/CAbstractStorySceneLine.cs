using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAbstractStorySceneLine : CStorySceneElement
{
#region RED Properties

[REDProp("elementID")]
public string ElementID { get; set;}

[REDProp("approvedDuration")]
public float ApprovedDuration { get; set;}

[REDProp("isCopy")]
public bool IsCopy { get; set;}

[REDProp("voicetag")]
public CName Voicetag { get; set;}

[REDProp("comment")]
public LocalizedString Comment { get; set;}

[REDProp("speakingTo")]
public CName SpeakingTo { get; set;}

#endregion
}
}