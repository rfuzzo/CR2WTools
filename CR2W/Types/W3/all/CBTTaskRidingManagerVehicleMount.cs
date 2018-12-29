using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRidingManagerVehicleMount : IBehTreeTask
{
#region RED Properties

[REDProp("mountType")]
public CName MountType { get; set;}

[REDProp("riderData")]
public Handle<CAIStorageRiderData> RiderData { get; set;}

[REDProp("attachSlot")]
public CName AttachSlot { get; set;}

#endregion
}
}