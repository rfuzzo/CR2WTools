using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGrassCellMask 
{
#region RED Properties

[REDProp("srtFileName")]
public string SrtFileName { get; set;}

[REDProp("firstRow")]
public Int32 FirstRow { get; set;}

[REDProp("lastRow")]
public Int32 LastRow { get; set;}

[REDProp("firstCol")]
public Int32 FirstCol { get; set;}

[REDProp("lastCol")]
public Int32 LastCol { get; set;}

[REDProp("cellSize")]
public float CellSize { get; set;}

[REDProp("bitmap")]
public LongBitField Bitmap { get; set;}

#endregion
}
}