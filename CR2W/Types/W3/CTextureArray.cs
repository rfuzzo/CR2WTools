using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CTextureArray : CResource
{
#region RED Properties

[REDProp("bitmaps")]
public Array<CTextureArrayEntry> Bitmaps { get; set;}

[REDProp("textureGroup")]
public CName TextureGroup { get; set;}

#endregion
}
}