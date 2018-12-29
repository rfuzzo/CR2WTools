using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAIReactionFactTest 
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

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