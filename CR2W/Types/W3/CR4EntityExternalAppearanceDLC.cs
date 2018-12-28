using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4EntityExternalAppearanceDLC : CObject
{
#region RED Properties

[REDProp("appearanceToRepleace")]
public CName AppearanceToRepleace { get; set;}

[REDProp("entityExternalAppearance")]
public Handle<CEntityExternalAppearance> EntityExternalAppearance { get; set;}

#endregion
}
}