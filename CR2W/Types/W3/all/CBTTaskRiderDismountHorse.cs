using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRiderDismountHorse : IBehTreeTask
{
#region RED Properties

[REDProp("riderData")]
public Handle<CAIStorageRiderData> RiderData { get; set;}

[REDProp("endDismountDone")]
public bool EndDismountDone { get; set;}

#endregion
}
}