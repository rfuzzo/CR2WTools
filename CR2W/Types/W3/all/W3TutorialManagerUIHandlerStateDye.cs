using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateDye : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("DYE")]
public CName DYE { get; set;}

[REDProp("DYE2")]
public CName DYE2 { get; set;}

[REDProp("DYE_REMOVER")]
public CName DYE_REMOVER { get; set;}

[REDProp("DYE_PREVIEW")]
public CName DYE_PREVIEW { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}