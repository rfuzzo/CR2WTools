using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCustomClippingPlanes 
{
#region RED Properties

[REDProp("nearPlaneDistance")]
public float NearPlaneDistance { get; set;}

[REDProp("farPlaneDistance")]
public float FarPlaneDistance { get; set;}

#endregion
}
}