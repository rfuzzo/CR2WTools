using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCCOpItemsToVirtualContainer : CCCOpVirtualContainerOp
{
#region RED Properties

[REDProp("virtualContainerTag")]
public CName VirtualContainerTag { get; set;}

[REDProp("canOverride")]
public bool CanOverride { get; set;}

#endregion
}
}