using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRiderSetMoveAlongPathWithCompanionActionOnHorse : IBehTreeTask
{
#region RED Properties

[REDProp("horseMoveAlongPathAction")]
public Handle<CAIMoveAlongPathWithCompanionAction> HorseMoveAlongPathAction { get; set;}

[REDProp("riderData")]
public Handle<CAIStorageRiderData> RiderData { get; set;}

#endregion
}
}