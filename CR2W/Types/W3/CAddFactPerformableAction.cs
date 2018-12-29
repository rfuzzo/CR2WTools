using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAddFactPerformableAction : IPerformableAction
{
#region RED Properties

[REDProp("factID")]
public string FactID { get; set;}

[REDProp("value")]
public int Value { get; set;}

[REDProp("validForSeconds")]
public int ValidForSeconds { get; set;}

#endregion
}
}