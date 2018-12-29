using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGraphConnection : ISerializable
{
#region RED Properties

[REDProp("source")]
public Ptr<CGraphSocket> Source { get; set;}

[REDProp("destination")]
public Ptr<CGraphSocket> Destination { get; set;}

[REDProp("inactive")]
public bool Inactive { get; set;}

#endregion
}
}