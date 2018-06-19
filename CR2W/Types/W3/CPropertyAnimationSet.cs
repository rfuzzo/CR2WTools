using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CPropertyAnimationSet : CResource
    {
        [W3Type("animations")]
        [W3ArrayFlags(2, 0)]
        public SPropertyAnimation Animations { get; set; }
        
    }
}
 