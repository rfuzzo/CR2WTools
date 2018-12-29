using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ItemSelectMenuInitData : CObject
{
#region RED Properties

[REDProp("onlyEquipped")]
public bool OnlyEquipped { get; set;}

[REDProp("onlyUnequipped")]
public bool OnlyUnequipped { get; set;}

[REDProp("containTags")]
public Array<CName> ContainTags { get; set;}

#endregion
}
}