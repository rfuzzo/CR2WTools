using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SGameplayAdditiveLevel 
{
#region RED Properties

[REDProp("useLevel")]
public bool UseLevel { get; set;}

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("animations")]
public Array<SGameplayAdditiveAnimation> Animations { get; set;}

#endregion
}
}