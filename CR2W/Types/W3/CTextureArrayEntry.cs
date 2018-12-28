using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CTextureArrayEntry 
{
#region RED Properties

[REDProp("m_texture")]
public Soft<CBitmapTexture> M_texture { get; set;}

#endregion
}
}