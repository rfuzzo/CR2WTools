using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormationPatternSlotsNode : IFormationPatternNode
{
#region RED Properties

[REDProp("slots")]
public Array<CFormationSlotDefinition> Slots { get; set;}

#endregion
}
}