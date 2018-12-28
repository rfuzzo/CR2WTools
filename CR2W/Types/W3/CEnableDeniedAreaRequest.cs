using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEnableDeniedAreaRequest : IEntityStateChangeRequest
{
#region RED Properties

[REDProp("enable")]
public bool Enable { get; set;}

#endregion
}
}