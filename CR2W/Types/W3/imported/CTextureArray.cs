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
public class CTextureArray : CResource
{
#region RED Properties

[REDProp("bitmaps", 2,0)]
public Array<CTextureArrayEntry> Bitmaps { get; set;}

[REDProp("textureGroup")]
public CName TextureGroup { get; set;}

#endregion
}
}