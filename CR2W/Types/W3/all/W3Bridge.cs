using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Bridge : W3DestroyableTerrain
{
#region RED Properties

[REDProp("m_currentFxID")]
public Int32 M_currentFxID { get; set;}

[REDProp("entryTime")]
public float EntryTime { get; set;}

[REDProp("timerInterval")]
public float TimerInterval { get; set;}

[REDProp("rot")]
public EulerAngles Rot { get; set;}

#endregion
}
}