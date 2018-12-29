using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CQuestJournalStatusCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("entry")]
public Handle<CJournalPath> Entry { get; set;}

[REDProp("status")]
public EJournalStatus Status { get; set;}

[REDProp("inverted")]
public bool Inverted { get; set;}

#endregion
}
}