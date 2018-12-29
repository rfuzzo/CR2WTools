using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CInventoryInitializerUniform : IInventoryInitializer
{
#region RED Properties

[REDProp("itemName")]
public CName ItemName { get; set;}

#endregion
}
}