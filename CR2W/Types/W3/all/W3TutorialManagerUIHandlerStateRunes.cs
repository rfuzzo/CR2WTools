using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateRunes : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SELECT")]
public CName SELECT { get; set;}

[REDProp("RUNE")]
public CName RUNE { get; set;}

[REDProp("SWORD")]
public CName SWORD { get; set;}

#endregion
}
}