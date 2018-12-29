using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEquipmentDefinitionEntry : CObject
{
#region RED Properties

[REDProp("category")]
public CName Category { get; set;}

[REDProp("defaultItemName")]
public CName DefaultItemName { get; set;}

[REDProp("initializer")]
public Ptr<IEquipmentInitializer> Initializer { get; set;}

#endregion
}
}