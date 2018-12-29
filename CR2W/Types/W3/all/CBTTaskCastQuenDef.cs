using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCastQuenDef : CBTTaskCastSignDef
{
#region RED Properties

[REDProp("completeAfterHit")]
public bool CompleteAfterHit { get; set;}

[REDProp("alternateFireMode")]
public bool AlternateFireMode { get; set;}

[REDProp("processQuenOnCounterActivation")]
public bool ProcessQuenOnCounterActivation { get; set;}

#endregion
}
}