using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehaviorComboDirection 
{
#region RED Properties

[REDProp("distSmall")]
public SBehaviorComboDistance DistSmall { get; set;}

[REDProp("distMedium")]
public SBehaviorComboDistance DistMedium { get; set;}

[REDProp("distLarge")]
public SBehaviorComboDistance DistLarge { get; set;}

#endregion
}
}