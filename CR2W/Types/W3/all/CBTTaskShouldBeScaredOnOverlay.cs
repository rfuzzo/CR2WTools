using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskShouldBeScaredOnOverlay : IBehTreeTask
{
#region RED Properties

[REDProp("infantInHand")]
public bool InfantInHand { get; set;}

[REDProp("catOnLap")]
public bool CatOnLap { get; set;}

[REDProp("jobTreeType")]
public EJobTreeType JobTreeType { get; set;}

#endregion
}
}