using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TreasureHuntMappinEntity : CR4MapPinEntity
{
#region RED Properties

[REDProp("mappinSet")]
public bool MappinSet { get; set;}

[REDProp("isDisabled")]
public bool IsDisabled { get; set;}

[REDProp("regionType")]
public EEP2PoiType RegionType { get; set;}

#endregion
}
}