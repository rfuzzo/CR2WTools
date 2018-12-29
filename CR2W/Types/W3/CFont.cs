using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CFont : CResource
    {
        [REDProp("textures", 2, 0)]
        public Array<Handle<CBitmapTexture>> Textures { get; set; }
    }
}
