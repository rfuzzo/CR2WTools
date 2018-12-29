using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FloeEntityStateOnPreDestroy : W3DestroyableTerrainStateOnPreDestroy
{
#region RED Properties

[REDProp("entryTime")]
public float EntryTime { get; set;}

[REDProp("timerInterval")]
public float TimerInterval { get; set;}

#endregion
}
}