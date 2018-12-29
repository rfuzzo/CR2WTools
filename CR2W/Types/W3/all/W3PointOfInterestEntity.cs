using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PointOfInterestEntity : CGameplayEntity
{
#region RED Properties

[REDProp("toDestroy")]
public bool ToDestroy { get; set;}

[REDProp("assignedDispenser")]
public Handle<W3POIDispenser> AssignedDispenser { get; set;}

#endregion
}
}