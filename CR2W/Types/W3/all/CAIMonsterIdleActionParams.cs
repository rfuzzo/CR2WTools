using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterIdleActionParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("loopTime")]
public float LoopTime { get; set;}

[REDProp("actionName")]
public CName ActionName { get; set;}

[REDProp("onlyOnGround")]
public bool OnlyOnGround { get; set;}

#endregion
}
}