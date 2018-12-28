using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCCOpItemsFromVirtualContainer : CCCOpVirtualContainerOp
{
#region RED Properties

[REDProp("virtualContainerTag")]
public CName VirtualContainerTag { get; set;}

[REDProp("applyMounts")]
public bool ApplyMounts { get; set;}

#endregion
}
}