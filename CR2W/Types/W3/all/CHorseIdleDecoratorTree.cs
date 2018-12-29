using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHorseIdleDecoratorTree : CAIMonsterIdleDecorator
{
#region RED Properties

[REDProp("actionPointSelector")]
public Handle<CHorseParkingActionPointSelector> ActionPointSelector { get; set;}

[REDProp("packName")]
public CName PackName { get; set;}

#endregion
}
}