using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class Color
    {
      

        [W3Type("Red")]
        public byte Red { get; set; } //uint8

        [W3Type("Green")]
        public byte Green { get; set; } //uint8

        [W3Type("Blue")]
        public byte Blue { get; set; } //uint8

        [W3Type("Alpha")]
        public byte Alpha { get; set; } //uint8


    }
}
 