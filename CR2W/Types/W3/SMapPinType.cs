using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SMapPinType 
{
#region RED Properties

[REDProp("typeName")]
public CName TypeName { get; set;}

[REDProp("icon")]
public string Icon { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("color")]
public Color Color { get; set;}

#endregion
}
}