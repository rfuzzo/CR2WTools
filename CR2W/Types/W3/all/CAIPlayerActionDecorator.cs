using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIPlayerActionDecorator : IPlayerActionDecorator
{
#region RED Properties

[REDProp("interruptOnInput")]
public bool InterruptOnInput { get; set;}

#endregion
}
}