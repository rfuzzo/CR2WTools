using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFollowOwnerTRG : IBehTreeTask
{
#region RED Properties

[REDProp("activationDistance")]
public float ActivationDistance { get; set;}

[REDProp("minimumDistance")]
public float MinimumDistance { get; set;}

[REDProp("ignoreEntityWithTag")]
public CName IgnoreEntityWithTag { get; set;}

[REDProp("attractor")]
public Handle<CActor> Attractor { get; set;}

#endregion
}
}