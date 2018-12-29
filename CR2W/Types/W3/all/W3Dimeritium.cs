using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Dimeritium : W3Petard
{
#region RED Properties

[REDProp("affectedFX")]
public CName AffectedFX { get; set;}

[REDProp("affectedFXCluster")]
public CName AffectedFXCluster { get; set;}

[REDProp("disableTimerCalled")]
public bool DisableTimerCalled { get; set;}

[REDProp("DISABLED_FX_CHECK_DELAY")]
public float DISABLED_FX_CHECK_DELAY { get; set;}

[REDProp("disabledFxDT")]
public float DisabledFxDT { get; set;}

#endregion
}
}