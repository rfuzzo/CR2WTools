using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GlossaryBooksMenu : CR4MenuBase
{
#region RED Properties

[REDProp("SORT_WEIGHT_PAINTINGS")]
public Int32 SORT_WEIGHT_PAINTINGS { get; set;}

[REDProp("SORT_WEIGHT_BOOKS")]
public Int32 SORT_WEIGHT_BOOKS { get; set;}

[REDProp("SORT_WEIGHT_Q")]
public Int32 SORT_WEIGHT_Q { get; set;}

[REDProp("SORT_WEIGHT_SQ")]
public Int32 SORT_WEIGHT_SQ { get; set;}

[REDProp("SORT_WEIGHT_MQ")]
public Int32 SORT_WEIGHT_MQ { get; set;}

[REDProp("SORT_WEIGHT_MH")]
public Int32 SORT_WEIGHT_MH { get; set;}

[REDProp("SORT_WEIGHT_TH")]
public Int32 SORT_WEIGHT_TH { get; set;}

#endregion
}
}