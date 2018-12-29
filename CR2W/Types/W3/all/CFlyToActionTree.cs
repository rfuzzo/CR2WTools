using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFlyToActionTree : IFlightActionTree
{
#region RED Properties

[REDProp("acceptDistance")]
public float AcceptDistance { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("rotateBeforeTakeOff")]
public bool RotateBeforeTakeOff { get; set;}

[REDProp("landAtTargetLocation")]
public bool LandAtTargetLocation { get; set;}

[REDProp("landingForwardOffset")]
public float LandingForwardOffset { get; set;}

#endregion
}
}