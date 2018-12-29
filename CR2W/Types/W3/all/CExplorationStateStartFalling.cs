using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateStartFalling : CExplorationStateAbstract
{
#region RED Properties

[REDProp("timeToJump")]
public float TimeToJump { get; set;}

[REDProp("fallCancelled")]
public bool FallCancelled { get; set;}

[REDProp("fallType")]
public EFallType FallType { get; set;}

[REDProp("behFallType")]
public CName BehFallType { get; set;}

[REDProp("cameraFallIsSet")]
public bool CameraFallIsSet { get; set;}

[REDProp("q704_gravit_shift")]
public bool Q704_gravit_shift { get; set;}

#endregion
}
}