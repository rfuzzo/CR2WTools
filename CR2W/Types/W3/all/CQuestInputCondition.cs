using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQuestInputCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("gameInput")]
public CName GameInput { get; set;}

[REDProp("valueCompareFunc")]
public EInputCompareFunc ValueCompareFunc { get; set;}

[REDProp("value")]
public float Value { get; set;}

#endregion
}
}