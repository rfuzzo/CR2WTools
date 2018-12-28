using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehaviorComboElem 
{
#region RED Properties

[REDProp("animations")]
public Array<SBehaviorComboAnim> Animations { get; set;}

[REDProp("enum")]
public CName Enum { get; set;}

#endregion
}
}