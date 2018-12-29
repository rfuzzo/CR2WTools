using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondLairEntityInRange : IBehTreeTask
{
#region RED Properties

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("checkCount")]
public Int32 CheckCount { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

#endregion
}
}