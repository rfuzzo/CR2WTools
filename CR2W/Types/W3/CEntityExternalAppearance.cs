using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEntityExternalAppearance : CResource
{
#region RED Properties

[REDProp("appearance")]
public CEntityAppearance Appearance { get; set;}

#endregion
}
}