using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class ApertureDofParams 
{
#region RED Properties

[REDProp("aperture")]
public EApertureValue Aperture { get; set;}

[REDProp("focalLength")]
public float FocalLength { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

#endregion
}
}