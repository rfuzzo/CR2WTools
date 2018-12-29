using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFoliageResource : CResource
{
#region RED Properties

[REDProp("bbox")]
public Box Bbox { get; set;}

[REDProp("gridbbox")]
public Box Gridbbox { get; set;}

[REDProp("version")]
public uint Version { get; set;}

#endregion
}
}