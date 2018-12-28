using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CVegetationBrushEntry : CObject
{
#region RED Properties

[REDProp("resource")]
public Handle<CSRTBaseTree> Resource { get; set;}

[REDProp("size")]
public float Size { get; set;}

[REDProp("sizeVar")]
public float SizeVar { get; set;}

[REDProp("radiusScale")]
public float RadiusScale { get; set;}

[REDProp("density")]
public float Density { get; set;}

#endregion
}
}