using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIChangeBehaviorGraphDecorator : IActionDecorator
{
#region RED Properties

[REDProp("graphWhenActivate")]
public CName GraphWhenActivate { get; set;}

[REDProp("graphWhenDeactivate")]
public CName GraphWhenDeactivate { get; set;}

#endregion
}
}