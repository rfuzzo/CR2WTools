using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicMeleeAttackDef : CBTTaskMagicAttackDef
{
#region RED Properties

[REDProp("resourceName")]
public CBehTreeValCName ResourceName { get; set;}

[REDProp("fxOnAnimEvent")]
public Array<SFxOnAnimEvent> FxOnAnimEvent { get; set;}

#endregion
}
}