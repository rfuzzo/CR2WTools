using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class NavigationCorrection : CObject
{
#region RED Properties

[REDProp("corrected")]
public bool Corrected { get; set;}

[REDProp("direction")]
public Vector Direction { get; set;}

[REDProp("angle")]
public float Angle { get; set;}

[REDProp("type")]
public EMovementCorrectionType Type { get; set;}

[REDProp("color")]
public Color Color { get; set;}

#endregion
}
}