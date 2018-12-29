using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcWorkIdleParams : CAIIdleParameters
{
#region RED Properties

[REDProp("actionPointSelector")]
public Handle<CActionPointSelector> ActionPointSelector { get; set;}

[REDProp("actionPointMoveType")]
public EMoveType ActionPointMoveType { get; set;}

#endregion
}
}