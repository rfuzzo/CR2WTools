using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSailorMountBoat : IBehTreeTask
{
#region RED Properties

[REDProp("boatTag")]
public CName BoatTag { get; set;}

[REDProp("riderData")]
public Handle<CAIStorageRiderData> RiderData { get; set;}

[REDProp("instantMount")]
public bool InstantMount { get; set;}

#endregion
}
}