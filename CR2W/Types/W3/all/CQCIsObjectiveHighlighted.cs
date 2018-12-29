using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQCIsObjectiveHighlighted : IUIConditionType
{
#region RED Properties

[REDProp("objectiveEntry")]
public Handle<CJournalPath> ObjectiveEntry { get; set;}

#endregion
}
}