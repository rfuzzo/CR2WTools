using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CVegetationBrush : CResource
{
#region RED Properties

[REDProp("entries")]
public Array<Ptr<CVegetationBrushEntry>> Entries { get; set;}

#endregion
}
}