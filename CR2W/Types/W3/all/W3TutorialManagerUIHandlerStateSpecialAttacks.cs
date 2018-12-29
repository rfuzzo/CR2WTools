using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateSpecialAttacks : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SPECIALS")]
public CName SPECIALS { get; set;}

[REDProp("ALTERNATES")]
public CName ALTERNATES { get; set;}

#endregion
}
}