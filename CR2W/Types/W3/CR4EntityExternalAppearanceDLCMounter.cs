using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4EntityExternalAppearanceDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("entityTemplatePaths")]
public Array<string> EntityTemplatePaths { get; set;}

[REDProp("entityExternalAppearances")]
public Array<Ptr<CR4EntityExternalAppearanceDLC>> EntityExternalAppearances { get; set;}

#endregion
}
}