using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGrassCellMask 
{
#region RED Properties

[REDProp("srtFileName")]
public string SrtFileName { get; set;}

[REDProp("firstRow")]
public int FirstRow { get; set;}

[REDProp("lastRow")]
public int LastRow { get; set;}

[REDProp("firstCol")]
public int FirstCol { get; set;}

[REDProp("lastCol")]
public int LastCol { get; set;}

[REDProp("cellSize")]
public float CellSize { get; set;}

[REDProp("bitmap")]
public LongBitField Bitmap { get; set;}

#endregion
}
}