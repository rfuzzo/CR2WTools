using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MagicBubbleEntity : W3BuffImmunityEntity
{
#region RED Properties

[REDProp("activeFxName")]
public CName ActiveFxName { get; set;}

[REDProp("damper")]
public Handle<VectorSpringDamper> Damper { get; set;}

#endregion
}
}