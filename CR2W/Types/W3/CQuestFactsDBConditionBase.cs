using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestFactsDBConditionBase : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("factId")]
public string FactId { get; set;}

[REDProp("queryFact")]
public EQueryFact QueryFact { get; set;}

[REDProp("value")]
public int Value { get; set;}

[REDProp("compareFunc")]
public ECompareFunc CompareFunc { get; set;}

#endregion
}
}