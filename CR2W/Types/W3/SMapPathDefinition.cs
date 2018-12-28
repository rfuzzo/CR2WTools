using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SMapPathDefinition 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("lineWidth")]
public float LineWidth { get; set;}

[REDProp("lineSegmentLength")]
public float LineSegmentLength { get; set;}

[REDProp("color")]
public Color Color { get; set;}

#endregion
}
}