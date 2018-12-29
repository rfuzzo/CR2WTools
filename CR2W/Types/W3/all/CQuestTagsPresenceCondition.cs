using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQuestTagsPresenceCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("all")]
public bool All { get; set;}

[REDProp("howMany")]
public uint HowMany { get; set;}

[REDProp("includeStubs")]
public bool IncludeStubs { get; set;}

#endregion
}
}