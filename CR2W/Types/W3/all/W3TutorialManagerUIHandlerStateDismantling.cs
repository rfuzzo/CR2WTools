using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateDismantling : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("ITEMS")]
public CName ITEMS { get; set;}

[REDProp("COMPONENTS")]
public CName COMPONENTS { get; set;}

[REDProp("COST")]
public CName COST { get; set;}

[REDProp("DISMANTLING")]
public CName DISMANTLING { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}