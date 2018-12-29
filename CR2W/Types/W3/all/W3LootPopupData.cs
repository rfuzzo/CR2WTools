using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LootPopupData : CObject
{
#region RED Properties

[REDProp("targetContainer")]
public Handle<W3Container> TargetContainer { get; set;}

#endregion
}
}