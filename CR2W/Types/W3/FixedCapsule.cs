using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class FixedCapsule 
{
#region RED Properties

[REDProp("PointRadius")]
public Vector PointRadius { get; set;}

[REDProp("Height")]
public float Height { get; set;}

#endregion
}
}