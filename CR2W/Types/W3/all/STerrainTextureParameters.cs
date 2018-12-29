using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class STerrainTextureParameters 
{
#region RED Properties

[REDProp("val")]
public Vector Val { get; set;}

[REDProp("val2")]
public Vector Val2 { get; set;}

#endregion
}
}