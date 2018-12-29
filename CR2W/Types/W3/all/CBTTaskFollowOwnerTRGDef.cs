using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFollowOwnerTRGDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("activationDistance")]
public float ActivationDistance { get; set;}

[REDProp("minimumDistance")]
public float MinimumDistance { get; set;}

[REDProp("ignoreEntityWithTag")]
public CName IgnoreEntityWithTag { get; set;}

#endregion
}
}