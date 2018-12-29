using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerModeTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("isPlayerInside")]
public bool IsPlayerInside { get; set;}

[REDProp("playerMode")]
public EPlayerMode PlayerMode { get; set;}

#endregion
}
}