using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SItemReward 
{
#region RED Properties

[REDProp("item")]
public CName Item { get; set;}

[REDProp("amount")]
public int Amount { get; set;}

#endregion
}
}