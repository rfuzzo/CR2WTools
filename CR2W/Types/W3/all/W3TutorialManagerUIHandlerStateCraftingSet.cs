using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateCraftingSet : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SET")]
public CName SET { get; set;}

#endregion
}
}