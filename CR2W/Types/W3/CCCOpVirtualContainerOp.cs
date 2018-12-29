using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCCOpVirtualContainerOp : ICharacterCustomizationOperation
{
#region RED Properties

[REDProp("virtualContainerTag")]
public CName VirtualContainerTag { get; set;}

#endregion
}
}