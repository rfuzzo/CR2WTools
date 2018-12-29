using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAISorceressMagicBubbleActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("magicBubbleResourceName")]
public CName MagicBubbleResourceName { get; set;}

[REDProp("deactivate")]
public bool Deactivate { get; set;}

[REDProp("playAnim")]
public bool PlayAnim { get; set;}

#endregion
}
}