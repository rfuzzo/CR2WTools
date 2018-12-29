using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMutationsEquippedCharPanel : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("EQUIPPED")]
public CName EQUIPPED { get; set;}

[REDProp("MUTAGENS")]
public CName MUTAGENS { get; set;}

[REDProp("MASTER")]
public CName MASTER { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}