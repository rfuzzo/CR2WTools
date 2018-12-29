using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CIndirectSlot : ISlot
{
#region RED Properties

[REDProp("slotIndex")]
public uint SlotIndex { get; set;}

#endregion
}
}