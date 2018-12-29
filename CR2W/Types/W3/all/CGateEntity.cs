using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGateEntity : W3LockableEntity
{
#region RED Properties

[REDProp("currState")]
public CName CurrState { get; set;}

[REDProp("speedModifier")]
public float SpeedModifier { get; set;}

[REDProp("initiallyOpened")]
public bool InitiallyOpened { get; set;}

[REDProp("startSound")]
public CName StartSound { get; set;}

[REDProp("stopSound")]
public CName StopSound { get; set;}

[REDProp("runTime")]
public float RunTime { get; set;}

#endregion
}
}