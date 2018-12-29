using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BuffDoTParams : W3BuffCustomParams
{
#region RED Properties

[REDProp("isEnvironment")]
public bool IsEnvironment { get; set;}

[REDProp("isPerk20Active")]
public bool IsPerk20Active { get; set;}

#endregion
}
}