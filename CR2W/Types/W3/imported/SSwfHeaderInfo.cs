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
public class SSwfHeaderInfo 
{
#region RED Properties

[REDProp("frameRate")]
public float FrameRate { get; set;}

[REDProp("frameHeight")]
public float FrameHeight { get; set;}

[REDProp("frameWidth")]
public float FrameWidth { get; set;}

[REDProp("frameCount")]
public int FrameCount { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("width")]
public float Width { get; set;}

[REDProp("version")]
public int Version { get; set;}

[REDProp("compressed")]
public bool Compressed { get; set;}

#endregion
}
}