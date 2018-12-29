using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LadderInteraction : CGameplayEntity
{
#region RED Properties

[REDProp("associatedDoorTag")]
public CName AssociatedDoorTag { get; set;}

[REDProp("associatedDoor")]
public Handle<W3NewDoor> AssociatedDoor { get; set;}

#endregion
}
}