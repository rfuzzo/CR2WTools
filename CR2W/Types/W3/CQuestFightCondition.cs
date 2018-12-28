using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestFightCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("attackerTag")]
public CName AttackerTag { get; set;}

[REDProp("referenceValue")]
public int ReferenceValue { get; set;}

[REDProp("damageMode")]
public EQueryFightMode DamageMode { get; set;}

#endregion
}
}