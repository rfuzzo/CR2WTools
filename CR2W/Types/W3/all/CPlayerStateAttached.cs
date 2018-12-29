using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerStateAttached : CPlayerStateBase
{
#region RED Properties

[REDProp("attachedTo")]
public Handle<CEntity> AttachedTo { get; set;}

[REDProp("slot")]
public CName Slot { get; set;}

#endregion
}
}