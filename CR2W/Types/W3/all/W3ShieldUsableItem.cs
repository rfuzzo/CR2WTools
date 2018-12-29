using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ShieldUsableItem : W3UsableItem
{
#region RED Properties

[REDProp("factAddedOnUse")]
public string FactAddedOnUse { get; set;}

[REDProp("factValue")]
public Int32 FactValue { get; set;}

[REDProp("factTimeValid")]
public Int32 FactTimeValid { get; set;}

[REDProp("removeFactOnHide")]
public bool RemoveFactOnHide { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}