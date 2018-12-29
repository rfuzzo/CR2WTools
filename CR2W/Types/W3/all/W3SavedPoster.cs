using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SavedPoster : W3Poster
{
#region RED Properties

[REDProp("savedFocusModeHighlight")]
public EFocusModeVisibility SavedFocusModeHighlight { get; set;}

#endregion
}
}