using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateMutagenDismantlingTable : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DESCRIPTION")]
public CName DESCRIPTION { get; set;}

[REDProp("WHY_DO_IT")]
public CName WHY_DO_IT { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}