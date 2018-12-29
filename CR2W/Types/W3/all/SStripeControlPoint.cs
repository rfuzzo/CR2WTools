using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SStripeControlPoint 
{
#region RED Properties

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("rotation")]
public EulerAngles Rotation { get; set;}

[REDProp("blendOffset")]
public float BlendOffset { get; set;}

#endregion
}
}