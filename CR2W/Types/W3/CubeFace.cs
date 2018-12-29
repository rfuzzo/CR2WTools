using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CubeFace 
{
#region RED Properties

[REDProp("m_texture")]
public Handle<CBitmapTexture> M_texture { get; set;}

[REDProp("sourceTexture")]
public Handle<CSourceTexture> SourceTexture { get; set;}

[REDProp("m_rotate")]
public bool M_rotate { get; set;}

[REDProp("m_flipX")]
public bool M_flipX { get; set;}

[REDProp("m_flipY")]
public bool M_flipY { get; set;}

#endregion
}
}