using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPartySpreadOrganizer : CPartySpawnOrganizer
{
#region RED Properties

[REDProp("spreadRadiusMin")]
public float SpreadRadiusMin { get; set;}

[REDProp("spreadRadiusMax")]
public float SpreadRadiusMax { get; set;}

#endregion
}
}