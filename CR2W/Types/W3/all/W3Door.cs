using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Door : W3LockableEntity
{
#region RED Properties

[REDProp("rotDir")]
public Int32 RotDir { get; set;}

[REDProp("initiallyOpened")]
public bool InitiallyOpened { get; set;}

[REDProp("factOnPlayerDoorOpen")]
public CName FactOnPlayerDoorOpen { get; set;}

[REDProp("isOpened")]
public bool IsOpened { get; set;}

[REDProp("openInteractionComponent")]
public Handle<CInteractionComponent> OpenInteractionComponent { get; set;}

[REDProp("closeInteractionComponent")]
public Handle<CInteractionComponent> CloseInteractionComponent { get; set;}

#endregion
}
}