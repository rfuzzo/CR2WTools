using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQCIsObjectiveHighlighted : IUIConditionType
{
#region RED Properties

[REDProp("objectiveEntry")]
public Handle<CJournalPath> ObjectiveEntry { get; set;}

#endregion
}
}