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
public class SSwfFontDesc 
{
#region RED Properties

[REDProp("fontName")]
public string FontName { get; set;}

[REDProp("numGlyphs")]
public UInt32 NumGlyphs { get; set;}

[REDProp("italic")]
public bool Italic { get; set;}

[REDProp("bold")]
public bool Bold { get; set;}

#endregion
}
}