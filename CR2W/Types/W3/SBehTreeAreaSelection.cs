using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehTreeAreaSelection 
{
#region RED Properties

[REDProp("selectionMode")]
public CBehTreeValAreaSelectionMode SelectionMode { get; set;}

[REDProp("optionalAreaTag")]
public CBehTreeValCName OptionalAreaTag { get; set;}

#endregion
}
}