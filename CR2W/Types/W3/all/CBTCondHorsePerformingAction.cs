using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondHorsePerformingAction : IBehTreeTask
{
#region RED Properties

[REDProp("mounting")]
public bool Mounting { get; set;}

[REDProp("dismounting")]
public bool Dismounting { get; set;}

[REDProp("inAir")]
public bool InAir { get; set;}

#endregion
}
}