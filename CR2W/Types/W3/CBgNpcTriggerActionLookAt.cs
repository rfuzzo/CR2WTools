using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBgNpcTriggerActionLookAt : IBgNpcTriggerAction
{
#region RED Properties

[REDProp("type")]
public EReactionLookAtType Type { get; set;}

[REDProp("onlyPlayer")]
public bool OnlyPlayer { get; set;}

[REDProp("maxDelay")]
public float MaxDelay { get; set;}

#endregion
}
}