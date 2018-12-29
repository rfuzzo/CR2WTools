using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CInventoryDefinitionEntry : CObject
{
#region RED Properties

[REDProp("category")]
public CName Category { get; set;}

[REDProp("quantityMin")]
public uint QuantityMin { get; set;}

[REDProp("quantityMax")]
public uint QuantityMax { get; set;}

[REDProp("probability")]
public float Probability { get; set;}

[REDProp("isMount")]
public bool IsMount { get; set;}

[REDProp("isLootable")]
public bool IsLootable { get; set;}

[REDProp("initializer")]
public Ptr<IInventoryInitializer> Initializer { get; set;}

#endregion
}
}