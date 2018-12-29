using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveTRGFollowLocomotion : CMoveTRGScript
{
#region RED Properties

[REDProp("attractor")]
public Handle<CNode> Attractor { get; set;}

[REDProp("minimumDistance")]
public float MinimumDistance { get; set;}

#endregion
}
}