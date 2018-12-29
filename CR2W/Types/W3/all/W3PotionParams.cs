using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PotionParams : W3BuffCustomParams
{
#region RED Properties

[REDProp("potionItemName")]
public CName PotionItemName { get; set;}

#endregion
}
}