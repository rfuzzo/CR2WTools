using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAttachmentReplacement 
{
#region RED Properties

[REDProp("oldName")]
public CName OldName { get; set;}

[REDProp("oldClass")]
public CName OldClass { get; set;}

[REDProp("newName")]
public CName NewName { get; set;}

[REDProp("newClass")]
public CName NewClass { get; set;}

#endregion
}
}