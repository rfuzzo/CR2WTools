using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SInventoryItemUIData 
{
#region RED Properties

[REDProp("gridPosition")]
public int GridPosition { get; set;}

[REDProp("gridSize")]
public int GridSize { get; set;}

[REDProp("isNew")]
public bool IsNew { get; set;}

#endregion
}
}