using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ContextMenu : W3PopupData
{
#region RED Properties

[REDProp("positionX")]
public float PositionX { get; set;}

[REDProp("positionY")]
public float PositionY { get; set;}

[REDProp("contextRef")]
public Handle<W3UIContext> ContextRef { get; set;}

[REDProp("actionsList")]
public Array<SKeyBinding> ActionsList { get; set;}

[REDProp("curActionNavCode")]
public string CurActionNavCode { get; set;}

#endregion
}
}