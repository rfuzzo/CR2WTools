using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SMapPathInstance 
{
#region RED Properties

[REDProp("id")]
public int Id { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("splinePoints")]
public Array<Vector> SplinePoints { get; set;}

[REDProp("color")]
public int Color { get; set;}

[REDProp("lineWidth")]
public float LineWidth { get; set;}

[REDProp("isAddedToMinimap")]
public bool IsAddedToMinimap { get; set;}

#endregion
}
}