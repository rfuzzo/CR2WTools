using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcTacticTreeParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("specialActions")]
public Array<Handle<CAISpecialAction>> SpecialActions { get; set;}

[REDProp("dontUseRunWhileStrafing")]
public bool DontUseRunWhileStrafing { get; set;}

[REDProp("allowChangingGuard")]
public bool AllowChangingGuard { get; set;}

#endregion
}
}