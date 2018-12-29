using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CTimetableActionPointSelector : CActionPointSelector
{
#region RED Properties

[REDProp("timetable")]
public Array<CSStoryPhaseTimetableACategoriesTimetableEntry> Timetable { get; set;}

#endregion
}
}