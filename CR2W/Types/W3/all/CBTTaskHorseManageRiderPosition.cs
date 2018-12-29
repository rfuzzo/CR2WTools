using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseManageRiderPosition : IBehTreeTask
{
#region RED Properties

[REDProp("rider")]
public Handle<CActor> Rider { get; set;}

[REDProp("activation_distance")]
public float Activation_distance { get; set;}

#endregion
}
}