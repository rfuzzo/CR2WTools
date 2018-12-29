using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3InventoryInitData : W3MenuInitData
{
#region RED Properties

[REDProp("containerNPC")]
public Handle<CGameplayEntity> ContainerNPC { get; set;}

[REDProp("filterTagsList")]
public Array<CName> FilterTagsList { get; set;}

#endregion
}
}