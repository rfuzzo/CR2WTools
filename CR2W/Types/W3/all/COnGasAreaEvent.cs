using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class COnGasAreaEvent : CHudEvent
{
#region RED Properties

[REDProp("entered")]
public bool Entered { get; set;}

#endregion
}
}