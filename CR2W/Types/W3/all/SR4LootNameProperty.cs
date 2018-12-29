using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SR4LootNameProperty 
{
#region RED Properties

[REDProp("lootName")]
public CName LootName { get; set;}

#endregion
}
}