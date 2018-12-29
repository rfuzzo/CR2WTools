using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAttachmentReplacements 
{
#region RED Properties

[REDProp("replacements")]
public Array<SAttachmentReplacement> Replacements { get; set;}

#endregion
}
}