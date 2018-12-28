using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestReactionCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("fieldName")]
public CName FieldName { get; set;}

[REDProp("actorsTags")]
public TagList ActorsTags { get; set;}

#endregion
}
}