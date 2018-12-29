using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondBeingHit : IBehTreeTask
{
#region RED Properties

[REDProp("timeOnLastHit")]
public float TimeOnLastHit { get; set;}

[REDProp("beingHit")]
public bool BeingHit { get; set;}

#endregion
}
}