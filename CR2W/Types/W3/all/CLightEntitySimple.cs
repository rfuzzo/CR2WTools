using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CLightEntitySimple : CScheduledUsableEntity
{
#region RED Properties

[REDProp("isOn")]
public bool IsOn { get; set;}

#endregion
}
}