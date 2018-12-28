using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehaviorComboAnimation 
{
#region RED Properties

[REDProp("animationAttack")]
public CName AnimationAttack { get; set;}

[REDProp("animationParry")]
public CName AnimationParry { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

#endregion
}
}