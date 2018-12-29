using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMoveTRGDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("fleeDistance")]
public float FleeDistance { get; set;}

[REDProp("activationDistance")]
public float ActivationDistance { get; set;}

[REDProp("ignoreEntityWithTag")]
public CName IgnoreEntityWithTag { get; set;}

[REDProp("flee")]
public bool Flee { get; set;}

#endregion
}
}