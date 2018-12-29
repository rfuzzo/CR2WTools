using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SmartObject : CR4MapPinEntity
{
#region RED Properties

[REDProp("startAnim")]
public CName StartAnim { get; set;}

[REDProp("loopAnims")]
public Array<CName> LoopAnims { get; set;}

[REDProp("stopAnim")]
public CName StopAnim { get; set;}

[REDProp("canBeInterruptedByInput")]
public bool CanBeInterruptedByInput { get; set;}

[REDProp("m_currentUser")]
public Handle<CActor> M_currentUser { get; set;}

[REDProp("m_saveLockID")]
public Int32 M_saveLockID { get; set;}

[REDProp("possibleItemSlots")]
public Array<CName> PossibleItemSlots { get; set;}

#endregion
}
}