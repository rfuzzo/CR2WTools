using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NPCBackground : CGameplayEntity
{
#region RED Properties

[REDProp("work")]
public EBackgroundNPCWork_Single Work { get; set;}

[REDProp("parentPairedBackgroundNPCEntity")]
public Handle<W3NPCBackgroundPair> ParentPairedBackgroundNPCEntity { get; set;}

[REDProp("isWorkingSingle")]
public bool IsWorkingSingle { get; set;}

#endregion
}
}