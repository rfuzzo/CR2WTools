using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondSwarmShieldAvailable : IBehTreeTask
{
#region RED Properties

[REDProp("checkIsShieldInPlace")]
public bool CheckIsShieldInPlace { get; set;}

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

#endregion
}
}