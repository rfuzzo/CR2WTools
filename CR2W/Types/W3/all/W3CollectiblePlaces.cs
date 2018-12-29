using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CollectiblePlaces : CGameplayEntity
{
#region RED Properties

[REDProp("xpPoints")]
public Int32 XpPoints { get; set;}

[REDProp("wasDiscovered")]
public bool WasDiscovered { get; set;}

[REDProp("allTags")]
public Array<CName> AllTags { get; set;}

#endregion
}
}