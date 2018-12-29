using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPickUpAndThrowDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("projectileTemplate")]
public Handle<CEntityTemplate> ProjectileTemplate { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

#endregion
}
}