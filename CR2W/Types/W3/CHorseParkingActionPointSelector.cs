using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CHorseParkingActionPointSelector : CActionPointSelector
{
#region RED Properties

[REDProp("apTags")]
public TagList ApTags { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

#endregion
}
}