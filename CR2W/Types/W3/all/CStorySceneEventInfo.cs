using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventInfo 
{
#region RED Properties

[REDProp("eventGuid")]
public CGUID EventGuid { get; set;}

[REDProp("sectionVariantId")]
public uint SectionVariantId { get; set;}

#endregion
}
}