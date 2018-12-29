using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFont : CResource
{
#region RED Properties

[REDProp("textures")]
public Array<Handle<CBitmapTexture>> Textures { get; set;}

#endregion
}
}