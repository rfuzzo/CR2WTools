using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneSectionVariantElementInfo 
{
#region RED Properties

[REDProp("elementId")]
public string ElementId { get; set;}

[REDProp("approvedDuration")]
public float ApprovedDuration { get; set;}

#endregion
}
}