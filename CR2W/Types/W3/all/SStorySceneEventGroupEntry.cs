using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SStorySceneEventGroupEntry 
{
#region RED Properties

[REDProp("time")]
public float Time { get; set;}

[REDProp("event")]
public Ptr<CStorySceneEvent> Event { get; set;}

#endregion
}
}