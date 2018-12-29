using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageBuffImmunity : IBehTreeTask
{
#region RED Properties

[REDProp("effects")]
public Array<EEffectType> Effects { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("bRemove")]
public bool BRemove { get; set;}

[REDProp("removeFromTemplate")]
public bool RemoveFromTemplate { get; set;}

#endregion
}
}