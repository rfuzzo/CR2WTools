using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SWorldMapImageInfo 
{
#region RED Properties

[REDProp("cropRect")]
public Rect CropRect { get; set;}

[REDProp("baseFileName")]
public string BaseFileName { get; set;}

[REDProp("height")]
public int Height { get; set;}

[REDProp("width")]
public int Width { get; set;}

#endregion
}
}