using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskThrowBombDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("dontUseDiwmeritium")]
public bool DontUseDiwmeritium { get; set;}

[REDProp("activationChance")]
public float ActivationChance { get; set;}

#endregion
}
}