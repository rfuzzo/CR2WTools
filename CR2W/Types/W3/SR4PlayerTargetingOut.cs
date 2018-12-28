using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SR4PlayerTargetingOut 
{
#region RED Properties

[REDProp("target")]
public Handle<CActor> Target { get; set;}

[REDProp("result")]
public bool Result { get; set;}

[REDProp("confirmNewTarget")]
public bool ConfirmNewTarget { get; set;}

[REDProp("forceDisableUpdatePosition")]
public bool ForceDisableUpdatePosition { get; set;}

#endregion
}
}