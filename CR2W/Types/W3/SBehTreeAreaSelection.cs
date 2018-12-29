using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehTreeAreaSelection 
{
#region RED Properties

[REDProp("selectionMode")]
public CBehTreeValAreaSelectionMode SelectionMode { get; set;}

[REDProp("optionalAreaTag")]
public CBehTreeValCName OptionalAreaTag { get; set;}

#endregion
}
}