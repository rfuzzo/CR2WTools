using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBuffImmunity 
{
#region RED Properties

[REDProp("immunityTo")]
public Array<Int32> ImmunityTo { get; set;}

[REDProp("potion")]
public bool Potion { get; set;}

[REDProp("positive")]
public bool Positive { get; set;}

[REDProp("negative")]
public bool Negative { get; set;}

[REDProp("neutral")]
public bool Neutral { get; set;}

[REDProp("immobilize")]
public bool Immobilize { get; set;}

[REDProp("confuse")]
public bool Confuse { get; set;}

[REDProp("damage")]
public bool Damage { get; set;}

#endregion
}
}