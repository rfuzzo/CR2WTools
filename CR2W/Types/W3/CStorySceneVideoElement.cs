using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneVideoElement : CStorySceneElement
{
#region RED Properties

[REDProp("elementID")]
public string ElementID { get; set;}

[REDProp("approvedDuration")]
public float ApprovedDuration { get; set;}

[REDProp("isCopy")]
public bool IsCopy { get; set;}

[REDProp("description")]
public string Description { get; set;}

#endregion
}
}